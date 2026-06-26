using demo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.VisualBasic;

namespace demo
{//start of namespace
    public partial class MainWindow : Window
    {//start of partial class
        ArrayList reply = new ArrayList();
        ArrayList ignore = new ArrayList();

        user_name check_name = new user_name();
        ai_handler ai;

        taskManager taskManager = new taskManager();

        Quiz quiz = new Quiz();

        int currentQuestion = 0;
        int score = 0;
        bool quizStarted = false;

      


        NLP_handler nlp = new NLP_handler();

        Quiz quizGame = new Quiz();

        //global variable to hold task details

        string task_name, task_description, task_dueDate, task_Status = string.Empty;   

        string username = string.Empty;
        int counting = 0;
        

        public MainWindow()
        {//start of mainwindow
            InitializeComponent();
            //call the mothod for the connection 
            taskManager.test_connection();

            new respond(reply, ignore);

            ai = new ai_handler(reply, ignore);

            //voice greeting
            voice_greeting greet = new voice_greeting();
            greet.greet();
        }// end of main window

        // get started button
        private void proceed(object sender, RoutedEventArgs e)
        {
            home_grid.Visibility = Visibility.Hidden;
            username_grid.Visibility = Visibility.Visible;
        }

        // Submit username
        private void submit_name(object sender, RoutedEventArgs e)
        {//start of subit name method
            // Get username
            string enteredName = usernames_input.Text.Trim();

            // Check if empty
            if (string.IsNullOrWhiteSpace(enteredName))
            {//start of if
                username_error.Text = "Please enter a valid username.";
                username_error.Visibility = Visibility.Visible;

                return;
            }//end of if

            // Hide error if valid
            username_error.Visibility = Visibility.Hidden;

            // Save username
            username = check_name.submit_name(usernames_input, chats);

            // Open chat page
            username_grid.Visibility = Visibility.Hidden;
            chat_grid.Visibility = Visibility.Visible;
        }//end of method

        //send button
        private void send(object sender, RoutedEventArgs e)
        {
            string rawQuestion = question.Text.Trim();

            if (string.IsNullOrWhiteSpace(rawQuestion))
            {
                error_method("ChatBot", "Please enter a question.");
                return;
            }

            // Display user's message
            error_method(username, rawQuestion);

            string cleanedQuestion = ai.RemoveSpecialCharacters(rawQuestion);

            // Detect what the user wants to do
            string intent = nlp.DetectIntent(cleanedQuestion);

            
            // ADD TASK
           
            if (cleanedQuestion.ToLower().StartsWith("add task"))
            {
                task_name = cleanedQuestion.Replace("add task", "").Trim();



                task_description = ai.ai_check(task_name, username);

                error_method("ChatBot",
                    "Great! Your task has been added.\nWould you like a reminder? (Example: yes remind me in 3 days)");

                question.Clear();
                return;
            }

            
            // REMINDER
        
            if (cleanedQuestion.ToLower().StartsWith("yes"))
            {
                string reminder = cleanedQuestion.Replace("yes remind me in", "").Trim();

                string days_number = Regex.Replace(reminder, @"[^0-9]", "");

                if (int.TryParse(days_number, out int days))
                {
                    DateTime due = DateTime.Now.AddDays(days);

                    task_dueDate = due.ToString("MMMM dd yyyy");
                    task_Status = "Pending";

                    taskManager.insert_task(task_name,
                                            task_description,
                                            task_dueDate,
                                            task_Status);

                    error_method("ChatBot",
                        "Perfect! I'll remind you on " + task_dueDate + ".");

                }
                else
                {
                    error_method("ChatBot",
                        "Please enter the number of days.\nExample: yes remind me in 5 days");
                }

                question.Clear();
                return;
            }

            
            // QUIZ
         
            if (intent == "quiz")
            {
                currentQuestion = 0;
                score = 0;
                quizStarted = true;

                error_method("Quiz",
                    quiz.GetQuestions()[currentQuestion].Text);

                question.Clear();
                return;
            }

            // ==========================
            // NORMAL CHATBOT
            // ==========================
            auto_show_interest();

            string response = ai.ai_check(cleanedQuestion, username);

            error_method("ChatBot", response);

            question.Clear();
        }

        // Show interests after 3 chats
        private void auto_show_interest()
        {//start of show interest method
            if (counting == 3)
            {
                string reminder = ai.GetInterestReminder(username);

                if (!string.IsNullOrWhiteSpace(reminder))
                {
                    error_method("ChatBot", reminder);
                }

                counting = 0;
            }
            else
            {
                counting++;
            }
        }//end of show interest method

        // Chat UI method
        private void error_method(string name, string message)
        {//start of error method
            Border messageBorder = new Border
            {
                Margin = new Thickness(0, 2, 0, 2),
                Padding = new Thickness(5, 3, 5, 3),
                CornerRadius = new CornerRadius(5)
            };

            // Different colors
            if (name.ToLower().Contains("chatbot") || name.ToLower().Contains("chat"))
            {
                messageBorder.Background = new SolidColorBrush(Color.FromRgb(240, 248, 255));
                messageBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(128, 0, 128));
            }
            else
            {
                messageBorder.Background = new SolidColorBrush(Color.FromRgb(255, 105, 180));
                messageBorder.BorderBrush = new SolidColorBrush(Color.FromRgb(128, 0, 128));
            }

            messageBorder.BorderThickness = new Thickness(1);

            TextBlock messageText = new TextBlock
            {
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(2)
            };

            messageText.Inlines.Add(new Run
            {
                Text = name + ": ",
                Foreground = Brushes.Purple,
                FontWeight = FontWeights.Bold
            });

            messageText.Inlines.Add(new Run
            {
                Text = message,
                Foreground = Brushes.Black
            });

            messageBorder.Child = messageText;

            chats.Items.Add(messageBorder);

            chats.ScrollIntoView(chats.Items[chats.Items.Count - 1]);
        }//end of method

        //event handler for submitting tasks
        private void submit_task(object sender, RoutedEventArgs e)
        {
            //colect users input
            //what you collect from tectbox will always be collected as a 
            //string datatype and if its a number then use int.Parse

            //temp variables
            
            string user_input = question.Text.Trim();


            //add this partbefore it searches for the answer, make it be the first line in that method
            //check if user is asking a question or adding a task

            if (user_input.ToLower().StartsWith("add task"))
            {

                //add the task to the listview as part of the chats
                chats.Items.Add("Great your task is added, would you like a reminder?");

                //then filter to get the task name
                task_name = user_input.Replace("add task", "");

                MessageBox.Show(task_name);

                task_description = ai.ai_check(task_name, username);

            }//end

            //check if the user wants a reminder
            if (user_input.ToLower().StartsWith("yes, remind me in"))
            {//start

                //replace the yes, remind me
                string reminder = user_input.Replace("yes, remind me in", "");


                //then get the number inside variable
                string days_number = Regex.Replace(reminder, @"[^0-9]", "");

                //cast the days _number to int
                if (int.TryParse(days_number, out int days))
                {
                    // Add the days the user chose to the current date
                    DateTime user_reminder = DateTime.Now.AddDays(days);

                    // Format the date
                    string format_date = user_reminder.ToString("MMMM dd yyyy");

                    // Save due date and status
                    task_dueDate = format_date;
                    task_Status = "Pending";

                    // Tell the user
                    chats.Items.Add("Good, I will remind you in " + days +
                                    " days, on " + format_date);

                    // Save the task
                    taskManager.insert_task(task_name, task_description,
                                            task_dueDate, task_Status);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of days.");
                }

            }

            }

        

        private void view_allTask(object sender, RoutedEventArgs e)
        {
            chat_grid.Visibility = Visibility.Hidden;
            viewTask_grid.Visibility = Visibility.Visible;

            view_tasks.Items.Clear();
            taskManager.load_tasks(view_tasks);
        }

        private void back_to_chats(object sender, RoutedEventArgs e)
        {
            viewTask_grid.Visibility = Visibility.Hidden;
            chat_grid.Visibility = Visibility.Visible;
        }

        //method to update tasks
        private void manage_task(object sender, MouseButtonEventArgs e)
        {
            if (view_tasks.SelectedItem == null)
                return;

            string selectedTask = view_tasks.SelectedItem.ToString();

            // Get the task ID (first number in the string)
            string number = Regex.Match(selectedTask, @"^\d+").Value;

            if (int.TryParse(number, out int taskID))
            {
                MessageBoxResult result = MessageBox.Show(
                    "Yes = Mark Complete\nNo = Delete\nChange = Update",
                    "Manage Task",
                    MessageBoxButton.YesNoCancel);

                if (result == MessageBoxResult.Yes)
                {
                    taskManager.complete_task(taskID);
                    MessageBox.Show("Task marked as completed.");
                }
                else if (result == MessageBoxResult.No)
                {
                    taskManager.delete_task(taskID);
                    MessageBox.Show("Task deleted.");
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    string newName = Microsoft.VisualBasic.Interaction.InputBox(
                        "Enter the new task name:",
                        "Update Task",
                        "");

                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        taskManager.update_task(taskID, newName);
                        MessageBox.Show("Task updated.");
                    }
                }

                // Refresh the ListView
                view_tasks.Items.Clear();
                taskManager.load_tasks(view_tasks);
            }
        }

        private void open_quiz(object sender, RoutedEventArgs e)
        {
            chat_grid.Visibility = Visibility.Hidden;
            quiz_grid.Visibility = Visibility.Visible;

            currentQuestion = 0;
            score = 0;

            ShowQuestion();
        }

        private void ShowQuestion()
        {
            questionText.Text =
                quiz.GetQuestions()[currentQuestion].Text;
        }

        private void submitAnswer(object sender, RoutedEventArgs e)
        {
            string answer = answerBox.Text.Trim();

            if (answer.Equals(
                quiz.GetQuestions()[currentQuestion].Answer,
                StringComparison.OrdinalIgnoreCase))
            {
                score++;
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show(
                    "Incorrect!\nCorrect answer: "
                    + quiz.GetQuestions()[currentQuestion].Answer);
            }

            currentQuestion++;

            if (currentQuestion >= quiz.GetQuestions().Count)
            {
                MessageBox.Show(
                    "Quiz Finished!\n\nScore: "
                    + score + "/" + quiz.GetQuestions().Count);

                quiz_grid.Visibility = Visibility.Hidden;
                chat_grid.Visibility = Visibility.Visible;

                return;
            }

            answerBox.Clear();
            ShowQuestion();
        }

        private void backToChat(object sender, RoutedEventArgs e)
        {
            quiz_grid.Visibility = Visibility.Hidden;
            chat_grid.Visibility = Visibility.Visible;
        }

    }//end of class 
}//end of namespace