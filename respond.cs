using System.Collections;

namespace demo
{//start of namespace
    public class respond
    {//start of public class
        public respond(ArrayList reply, ArrayList ignore)
        {//start of constructor

            answers(reply);
            words(ignore);


        }//end of constructor

        //method to store the list of words
        private void words(ArrayList ignoring)
        {
            //ignoring questions
            ignoring.Add("a");
            ignoring.Add("about");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyhow");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("anyway");
            ignoring.Add("anywhere");
            ignoring.Add("are");
            ignoring.Add("around");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("back");
            ignoring.Add("be");
            ignoring.Add("became");
            ignoring.Add("because");
            ignoring.Add("become");
            ignoring.Add("becomes");
            ignoring.Add("becoming");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("beforehand");
            ignoring.Add("behind");
            ignoring.Add("being");
            ignoring.Add("below");
            ignoring.Add("beside");
            ignoring.Add("besides");
            ignoring.Add("between");
            ignoring.Add("beyond");
            ignoring.Add("both");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("cannot");
            ignoring.Add("could");
            ignoring.Add("did");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("done");
            ignoring.Add("down");
            ignoring.Add("during");
            ignoring.Add("each");
            ignoring.Add("either");
            ignoring.Add("else");
            ignoring.Add("elsewhere");
            ignoring.Add("enough");
            ignoring.Add("etc");
            ignoring.Add("even");
            ignoring.Add("ever");
            ignoring.Add("every");
            ignoring.Add("everyone");
            ignoring.Add("everything");
            ignoring.Add("everywhere");
            ignoring.Add("except");
            ignoring.Add("few");
            ignoring.Add("first");
            ignoring.Add("for");
            ignoring.Add("former");
            ignoring.Add("formerly");
            ignoring.Add("from");
            ignoring.Add("further");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("hence");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("hereafter");
            ignoring.Add("hereby");
            ignoring.Add("herein");
            ignoring.Add("hereupon");
            ignoring.Add("hers");
            ignoring.Add("herself");
            ignoring.Add("him");
            ignoring.Add("himself");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("however");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("indeed");
            ignoring.Add("inside");
            ignoring.Add("instead");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("itself");
            ignoring.Add("last");
            ignoring.Add("later");
            ignoring.Add("latter");
            ignoring.Add("latterly");
            ignoring.Add("least");
            ignoring.Add("less");
            ignoring.Add("lot");
            ignoring.Add("many");
            ignoring.Add("may");
            ignoring.Add("me");
            ignoring.Add("meanwhile");
            ignoring.Add("might");
            ignoring.Add("more");
            ignoring.Add("moreover");
            ignoring.Add("most");
            ignoring.Add("mostly");
            ignoring.Add("much");
            ignoring.Add("must");
            ignoring.Add("my");
            ignoring.Add("myself");
            ignoring.Add("name");
            ignoring.Add("namely");
            ignoring.Add("neither");
            ignoring.Add("never");
            ignoring.Add("nevertheless");
            ignoring.Add("next");
            ignoring.Add("no");
            ignoring.Add("nobody");
            ignoring.Add("none");
            ignoring.Add("noone");
            ignoring.Add("nor");
            ignoring.Add("not");
            ignoring.Add("nothing");
            ignoring.Add("now");
            ignoring.Add("nowhere");
            ignoring.Add("of");
            ignoring.Add("off");
            ignoring.Add("often");
            ignoring.Add("on");
            ignoring.Add("once");
            ignoring.Add("one");
            ignoring.Add("only");
            ignoring.Add("or");
            ignoring.Add("other");
            ignoring.Add("others");
            ignoring.Add("otherwise");
            ignoring.Add("ought");
            ignoring.Add("our");
            ignoring.Add("ours");
            ignoring.Add("ourselves");
            ignoring.Add("out");
            ignoring.Add("outside");
            ignoring.Add("over");
            ignoring.Add("own");
            ignoring.Add("part");
            ignoring.Add("per");
            ignoring.Add("perhaps");
            ignoring.Add("please");
            ignoring.Add("put");
            ignoring.Add("rather");
            ignoring.Add("re");
            ignoring.Add("same");
            ignoring.Add("see");
            ignoring.Add("seem");
            ignoring.Add("seemed");
            ignoring.Add("seeming");
            ignoring.Add("seems");
            ignoring.Add("several");
            ignoring.Add("she");
            ignoring.Add("should");
            ignoring.Add("show");
            ignoring.Add("side");
            ignoring.Add("since");
            ignoring.Add("so");
            ignoring.Add("some");
            ignoring.Add("somehow");
            ignoring.Add("someone");
            ignoring.Add("something");
            ignoring.Add("sometime");
            ignoring.Add("sometimes");
            ignoring.Add("somewhere");
            ignoring.Add("still");
            ignoring.Add("such");
            ignoring.Add("take");
            ignoring.Add("than");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("theirs");
            ignoring.Add("them");
            ignoring.Add("themselves");
            ignoring.Add("then");
            ignoring.Add("thence");
            ignoring.Add("there");
            ignoring.Add("thereafter");
            ignoring.Add("thereby");
            ignoring.Add("therefore");
            ignoring.Add("therein");
            ignoring.Add("thereupon");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("those");
            ignoring.Add("though");
            ignoring.Add("through");
            ignoring.Add("throughout");
            ignoring.Add("thru");
            ignoring.Add("thus");
            ignoring.Add("to");
            ignoring.Add("together");
            ignoring.Add("too");
            ignoring.Add("toward");
            ignoring.Add("towards");
            ignoring.Add("under");
            ignoring.Add("unless");
            ignoring.Add("until");
            ignoring.Add("up");
            ignoring.Add("upon");
            ignoring.Add("us");
            ignoring.Add("used");
            ignoring.Add("very");
            ignoring.Add("via");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("well");
            ignoring.Add("were");
            ignoring.Add("what");
            ignoring.Add("whatever");
            ignoring.Add("when");
            ignoring.Add("whence");
            ignoring.Add("whenever");
            ignoring.Add("where");
            ignoring.Add("whereafter");
            ignoring.Add("whereas");
            ignoring.Add("whereby");
            ignoring.Add("wherein");
            ignoring.Add("whereupon");
            ignoring.Add("wherever");
            ignoring.Add("whether");
            ignoring.Add("which");
            ignoring.Add("while");
            ignoring.Add("whither");
            ignoring.Add("who");
            ignoring.Add("whoever");
            ignoring.Add("whole");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("within");
            ignoring.Add("without");
            ignoring.Add("would");
            ignoring.Add("yes");
            ignoring.Add("yet");
            ignoring.Add("hey");
            ignoring.Add("you");
            ignoring.Add("your");
            ignoring.Add("yours");
            ignoring.Add("yourself");
            ignoring.Add("yourselves");

        }//




        public void answers(ArrayList add_answers)
        {//start of method




            add_answers.Add("greeting i'm doing well, thanks for asking! how are you doing today ?");
            add_answers.Add("greeting i'm great today, thanks for asking! how can i help you today ?");
            add_answers.Add("greeting doing good! hope you are also doing well today ?");
            add_answers.Add("greeting hello! how can i help you today?");
            add_answers.Add("greeting hi there! what can i help you with?");
            add_answers.Add("greeting hey! i'm here to assist you.");
            add_answers.Add("greeting welcome! how are you today?");
            add_answers.Add("greeting good day! how can i assist?");
            add_answers.Add("greeting nice to see you! how may i help?");
            add_answers.Add("greeting hello! what cybersecurity question do you have?");


            add_answers.Add("purpose my purpose is to educate you on how to stay safe online and guide your cybersecurity questions.");
            add_answers.Add("purpose i help users understand online safety and digital protection.");
            add_answers.Add("purpose i assist with cybersecurity awareness and safety guidance.");
            add_answers.Add("purpose my purpose is to help users stay safe online.");
            add_answers.Add("purpose i provide guidance on cybersecurity awareness and digital safety.");
            add_answers.Add("purpose i help users understand online threats and how to avoid them.");
            add_answers.Add("purpose i aim to educate users about secure online practices.");
            add_answers.Add("purpose i assist with questions related to online security.");
            add_answers.Add("purpose i help people learn how to protect their information online.");
            add_answers.Add("purpose my goal is to improve awareness about cybersecurity risks.");


            add_answers.Add("cybersecurity cybersecurity is about protecting systems and networks from digital threats.");
            add_answers.Add("cybersecurity it involves protecting devices and online accounts from attacks.");
            add_answers.Add("cybersecurity it focuses on securing digital information and systems.");
            add_answers.Add("cybersecurity cybersecurity is the practice of protecting systems and data from threats.");
            add_answers.Add("cybersecurity it involves keeping information and devices secure.");
            add_answers.Add("cybersecurity cybersecurity helps protect networks from attacks.");
            add_answers.Add("cybersecurity it focuses on preventing unauthorized access to information.");
            add_answers.Add("cybersecurity cybersecurity includes methods for protecting digital systems.");
            add_answers.Add("cybersecurity it helps defend users against online risks and attacks.");
            add_answers.Add("cybersecurity cybersecurity aims to keep technology and information secure.");


            add_answers.Add("phishing phishing is a scam where attackers pretend to be trusted sources to steal information.");
            add_answers.Add("phishing it uses fake messages or websites to trick users into revealing sensitive data.");
            add_answers.Add("phishing attackers use deception to make users believe they are legitimate.");
            add_answers.Add("phishing phishing uses deception to steal information.");
            add_answers.Add("phishing attackers may pretend to be trusted companies.");
            add_answers.Add("phishing suspicious emails often contain urgent messages.");
            add_answers.Add("phishing avoid clicking unknown links.");
            add_answers.Add("phishing check the sender carefully.");
            add_answers.Add("phishing fake websites can look legitimate.");
            add_answers.Add("phishing verify requests before sharing information.");


            add_answers.Add("firewall a firewall controls network traffic based on security rules.");
            add_answers.Add("firewall it helps block unwanted access to your device or network.");
            add_answers.Add("firewall it acts as a protective barrier between trusted and untrusted networks.");
            add_answers.Add("firewall a firewall controls network traffic using security rules.");
            add_answers.Add("firewall it acts as a barrier between trusted and untrusted networks.");
            add_answers.Add("firewall firewalls help block unwanted access.");
            add_answers.Add("firewall a firewall monitors incoming and outgoing traffic.");
            add_answers.Add("firewall it improves security by filtering network activity.");
            add_answers.Add("firewall firewalls help protect devices from threats.");
            add_answers.Add("firewall it helps prevent unauthorized connections.");


            add_answers.Add("password a password is used to secure access to your accounts or devices.");
            add_answers.Add("password it should be strong, long and not easy to guess.");
            add_answers.Add("password avoid using personal details when creating one.");
            add_answers.Add("password use a strong and unique password.");
            add_answers.Add("password avoid using names or birthdays.");
            add_answers.Add("password create passwords with letters numbers and symbols.");
            add_answers.Add("password long passwords are harder to guess.");
            add_answers.Add("password avoid reusing passwords across accounts.");
            add_answers.Add("password update passwords regularly.");
            add_answers.Add("password consider using a password manager.");


            add_answers.Add("hacked account immediately secure your account and log out of all devices.");
            add_answers.Add("hacked account contact support if your account has been compromised.");
            add_answers.Add("hacked account enable extra security like two-factor authentication.");
            add_answers.Add("hacked account change your password immediately.");
            add_answers.Add("hacked account review account activity for unusual actions.");
            add_answers.Add("hacked account enable two-factor authentication.");
            add_answers.Add("hacked account log out from other devices.");
            add_answers.Add("hacked account contact support if needed.");
            add_answers.Add("hacked account secure linked accounts as well.");
            add_answers.Add("hacked account monitor for suspicious activity.");


            add_answers.Add("fraud contact your bank immediately if fraud is detected.");
            add_answers.Add("fraud report suspicious financial activity to the authorities.");
            add_answers.Add("fraud monitor your accounts for unusual activity.");
            add_answers.Add("fraud fraud involves deception used to gain money or sensitive information.");
            add_answers.Add("fraud scammers may pretend to be trusted individuals or companies.");
            add_answers.Add("fraud monitor your accounts for suspicious activity.");
            add_answers.Add("fraud report unusual financial activity as soon as possible.");
            add_answers.Add("fraud avoid sharing personal or banking information with unknown sources.");
            add_answers.Add("fraud be cautious of unexpected requests for money or sensitive details.");
            add_answers.Add("fraud verify information before responding to suspicious messages.");


            add_answers.Add("malicious chatbot malicious bots often create urgency to trick users.");
            add_answers.Add("malicious chatbot fake chatbots may ask for sensitive information.");
            add_answers.Add("malicious chatbot be cautious if a bot pressures you for personal data.");
            add_answers.Add("malicious chatbot malicious chatbots may pretend to be helpful while collecting information.");
            add_answers.Add("malicious chatbot fake chatbots can ask for personal or sensitive data.");
            add_answers.Add("malicious chatbot be cautious if a chatbot pressures you to act quickly.");
            add_answers.Add("malicious chatbot avoid sharing passwords or banking details with chatbots.");
            add_answers.Add("malicious chatbot malicious bots sometimes imitate trusted services.");
            add_answers.Add("malicious chatbot verify the source before trusting a chatbot.");
            add_answers.Add("malicious chatbot suspicious chatbot behavior can include unusual requests or urgency.");


            add_answers.Add("vpn a vpn helps protect your privacy on public wi-fi.");
            add_answers.Add("vpn it encrypts your internet traffic for safety.");
            add_answers.Add("vpn it improves security when using public networks.");
            add_answers.Add("vpn a vpn helps protect privacy online.");
            add_answers.Add("vpn it encrypts internet traffic.");
            add_answers.Add("vpn public wi-fi users often use vpn protection.");
            add_answers.Add("vpn it can improve privacy on networks.");
            add_answers.Add("vpn a vpn helps secure connections.");
            add_answers.Add("vpn it creates a protected connection.");
            add_answers.Add("vpn vpn services can reduce exposure on public networks.");

            add_answers.Add("public wi-fi public networks can have security risks.");
            add_answers.Add("public wi-fi avoid entering sensitive information.");
            add_answers.Add("public wi-fi use secure connections when possible.");
            add_answers.Add("public wi-fi avoid accessing banking information.");
            add_answers.Add("public wi-fi a vpn can provide additional protection.");
            add_answers.Add("public wi-fi only connect to trusted networks.");
            add_answers.Add("public wi-fi turn off automatic network connections.");

            add_answers.Add("scam scammers try to trick people into giving information or money.");
            add_answers.Add("scam be cautious of messages creating urgency.");
            add_answers.Add("scam verify information before responding.");
            add_answers.Add("scam avoid sharing sensitive details with unknown people.");
            add_answers.Add("scam unexpected offers can sometimes be misleading.");
            add_answers.Add("scam always double-check suspicious requests.");
            add_answers.Add("scam if something seems unusual investigate further.");

            add_answers.Add("malware malware is software designed to damage systems.");
            add_answers.Add("malware it can steal information from devices.");
            add_answers.Add("malware malicious software can affect performance.");
            add_answers.Add("malware malware may spread through downloads or links.");
            add_answers.Add("malware keeping software updated helps reduce risks.");
            add_answers.Add("malware security tools can help detect threats.");
            add_answers.Add("malware avoid downloading files from unknown sources.");

            add_answers.Add("antivirus antivirus software helps detect threats.");
            add_answers.Add("antivirus regular scans improve protection.");
            add_answers.Add("antivirus keep antivirus software updated.");
            add_answers.Add("antivirus security tools help reduce risks.");
            add_answers.Add("antivirus antivirus can identify harmful files.");
            add_answers.Add("antivirus use trusted antivirus software.");
            add_answers.Add("antivirus scanning regularly helps improve safety.");

            add_answers.Add("social media avoid oversharing personal details.");
            add_answers.Add("social media review privacy settings regularly.");
            add_answers.Add("social media only connect with trusted people.");
            add_answers.Add("social media avoid clicking suspicious links.");
            add_answers.Add("social media be careful with shared locations.");
            add_answers.Add("social media verify unknown requests.");
            add_answers.Add("social media use strong passwords on accounts.");


            //sentiment detection

            add_answers.Add("frustrated i understand you're frustrated. let's work through the issue step by step.");
            add_answers.Add("frustrated it's okay to feel frustrated when things aren't working. i'm here to help.");
            add_answers.Add("frustrated take a breath, we'll fix this together.");
            add_answers.Add("frustrated i understand this can feel frustrating. tell me what happened.");
            add_answers.Add("frustrated we'll work through the issue together.");
            add_answers.Add("frustrated i can see this is causing frustration. let's solve it step by step.");
            add_answers.Add("frustrated problems can be annoying sometimes. i'm here to help.");
            add_answers.Add("frustrated i'll do my best to help you find a solution.");
            add_answers.Add("frustrated tell me more so i can understand the issue better.");
            add_answers.Add("frustrated we'll figure out the problem together.");


            add_answers.Add("confused that's okay, confusion is normal. i'll explain it clearly for you.");
            add_answers.Add("confused let me break it down step by step so it makes sense.");
            add_answers.Add("confused no worries, i'll help you understand it better.");
            add_answers.Add("confused that's okay. i'll explain it more clearly.");
            add_answers.Add("confused let me simplify it for you.");
            add_answers.Add("confused confusion happens sometimes. i'll break it down.");
            add_answers.Add("confused i'll explain it step by step.");
            add_answers.Add("confused tell me which part seems unclear.");
            add_answers.Add("confused no worries. i'm here to help make it easier.");
            add_answers.Add("confused let's go through it together.");


            add_answers.Add("worried it's okay to feel worried. i'm here to help you stay safe online.");
            add_answers.Add("worried don't panic, most cybersecurity issues can be fixed quickly.");
            add_answers.Add("worried i understand your concern. let's make sure your information is safe.");
            add_answers.Add("worried i understand your concern and i'll help where i can.");
            add_answers.Add("worried tell me what's worrying you.");
            add_answers.Add("worried we'll look at the situation together.");
            add_answers.Add("worried cybersecurity concerns can often be managed with the right steps.");
            add_answers.Add("worried i'll help you understand what actions may help.");
            add_answers.Add("worried let's see what happened and what can be done.");
            add_answers.Add("worried your online safety matters and i'll assist you.");


            add_answers.Add("happy that's great to hear! i'm glad things are going well.");
            add_answers.Add("happy awesome! positivity is always good.");
            add_answers.Add("happy i'm happy for you! let me know if you need anything.");
            add_answers.Add("happy that's great to hear!");
            add_answers.Add("happy awesome! i'm glad things are going well.");
            add_answers.Add("happy nice! positive moments are always good.");
            add_answers.Add("happy happy to hear that!");
            add_answers.Add("happy that's wonderful news.");
            add_answers.Add("happy great! keep the positive energy going.");
            add_answers.Add("happy i'm glad things are working out.");


            add_answers.Add("sad i'm sorry you're feeling this way. i'm here for you.");
            add_answers.Add("sad that sounds tough, take things one step at a time.");
            add_answers.Add("sad i hope things improve soon. you can talk to me anytime.");
            add_answers.Add("sad i'm sorry you're feeling this way.");
            add_answers.Add("sad that sounds difficult and i'm here to listen.");
            add_answers.Add("sad i hope things improve soon.");
            add_answers.Add("sad take things one step at a time.");
            add_answers.Add("sad i'm here if you'd like to talk.");
            add_answers.Add("sad sometimes talking through things can help.");
            add_answers.Add("sad i appreciate you sharing that.");


            add_answers.Add("angry i understand you're angry. let's try solve the issue together.");
            add_answers.Add("angry it's okay to feel angry, but i'll help you fix the problem.");
            add_answers.Add("angry take your time, i'm here to help you sort it out.");
            add_answers.Add("angry i understand you're upset. tell me what happened.");
            add_answers.Add("angry i'll help you work through the issue.");
            add_answers.Add("angry i can see this situation is frustrating.");
            add_answers.Add("angry let's focus on finding a solution.");
            add_answers.Add("angry i'm listening and ready to help.");
            add_answers.Add("angry tell me more about what's causing the problem.");
            add_answers.Add("angry we'll try to sort this out together.");


            add_answers.Add("scared i understand that this feels unsettling.");
            add_answers.Add("scared i'm here to help you through the situation.");
            add_answers.Add("scared tell me what happened.");
            add_answers.Add("scared we'll look at it together.");
            add_answers.Add("scared many online problems have steps that can improve safety.");
            add_answers.Add("scared i'll help you understand your options.");
            add_answers.Add("scared let's focus on what can be done next.");

            add_answers.Add("stressed it sounds like you're under pressure right now.");
            add_answers.Add("stressed i'll help make things easier to understand.");
            add_answers.Add("stressed tell me what is causing the stress.");
            add_answers.Add("stressed we'll work through it one step at a time.");
            add_answers.Add("stressed i understand things can feel overwhelming sometimes.");
            add_answers.Add("stressed i'm here to help however i can.");
            add_answers.Add("stressed let's focus on one thing at a time.");


            add_answers.Add("excited that's exciting to hear!");
            add_answers.Add("excited awesome! sounds like good news.");
            add_answers.Add("excited i like the energy!");
            add_answers.Add("excited that's great!");
            add_answers.Add("excited exciting moments are always fun.");
            add_answers.Add("excited glad to hear you're feeling excited.");
            add_answers.Add("excited that's wonderful!");


            add_answers.Add("nervous it's understandable to feel nervous sometimes.");
            add_answers.Add("nervous tell me what's making you feel this way.");
            add_answers.Add("nervous i'm here to help if you want to talk about it.");
            add_answers.Add("nervous we'll work through the situation together.");
            add_answers.Add("nervous many situations feel easier once we understand them.");
            add_answers.Add("nervous i'll help however i can.");
            add_answers.Add("nervous take things one step at a time.");


            add_answers.Add("anxious i understand that you're feeling anxious.");
            add_answers.Add("anxious i'll help you through the situation.");
            add_answers.Add("anxious tell me what is making you feel anxious.");
            add_answers.Add("anxious we'll work through this together.");
            add_answers.Add("anxious i appreciate you sharing how you're feeling.");
            add_answers.Add("anxious let's focus on understanding the situation.");
            add_answers.Add("anxious i'm here to help however i can.");


            add_answers.Add("overwhelmed it sounds like there is a lot happening right now.");
            add_answers.Add("overwhelmed i'll help make things easier to understand.");
            add_answers.Add("overwhelmed tell me which part feels difficult.");
            add_answers.Add("overwhelmed we can work through things one part at a time.");
            add_answers.Add("overwhelmed i'm here to support you.");
            add_answers.Add("overwhelmed let's focus on the issue together.");
            add_answers.Add("overwhelmed we'll sort through it step by step.");


            add_answers.Add("disappointed i understand that this feels disappointing.");
            add_answers.Add("disappointed that can be difficult sometimes.");
            add_answers.Add("disappointed thank you for sharing how you feel.");
            add_answers.Add("disappointed i'm here if you want to talk about it.");
            add_answers.Add("disappointed let's see if we can improve the situation.");
            add_answers.Add("disappointed i'll help where i can.");
            add_answers.Add("disappointed sometimes situations become clearer with more information.");


            add_answers.Add("relieved i'm glad things feel better now.");
            add_answers.Add("relieved that's good to hear.");
            add_answers.Add("relieved great! it's nice when things work out.");
            add_answers.Add("relieved happy to hear that things improved.");
            add_answers.Add("relieved that's positive news.");
            add_answers.Add("relieved i'm glad the situation feels easier.");
            add_answers.Add("relieved good to hear everything is going better.");


            add_answers.Add("curious curiosity is a great way to learn.");
            add_answers.Add("curious feel free to ask questions.");
            add_answers.Add("curious i'm happy to explain things.");
            add_answers.Add("curious learning more can help build understanding.");
            add_answers.Add("curious that's an interesting question.");
            add_answers.Add("curious let's explore the topic together.");
            add_answers.Add("curious i'll do my best to explain clearly.");



        }//end of method


    }//end of claa
}//end of namespace