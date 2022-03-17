using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

namespace secretAgent
{
    public partial class Index : System.Web.UI.Page
    {
        // Arraylist med vores oprettede agenter
        static ArrayList agentArrayList;


        protected void Page_Load(object sender, EventArgs e)
        {
            // whether the page is being rendered for the first time or is responding to a postback.
            if (!Page.IsPostBack)
            {
                // Hvis siden bliver loaded for første gang = Ny arraylist + focus på text box med id
                agentArrayList = new ArrayList();
                TextBoxID.Focus();
            }

        }

        // Kode for når man klikker på Create button. OnClick function. 
        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            // Agent objekter oprettet fra vores Class SecretAgent. 
            // I Class lavede vi ID, name, codename, lang1 og lang 2. Dette bliver defineret her.
            // Vi converter id til integer fra string i vores textbox
            SecretAgent s = new SecretAgent(Convert.ToInt32(TextBoxID.Text), TextBoxName.Text, TextBoxCodename.Text, TextBoxLang1.Text, TextBoxLang2.Text);

            // Vores nye agent bliver gemt i vores array
            agentArrayList.Add(s);

            // Fjerner alt tekst fra tekstboks, så der er plads til nyt. 
            TextBoxID.Text = "";
            TextBoxName.Text = "";
            TextBoxCodename.Text = "";
            TextBoxLang1.Text = "";
            TextBoxLang2.Text = "";
            TextBoxID.Focus();
        }


        // Hvad der sker når vi klikker Show
        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            // 
            ListBoxShow.Items.Clear();

            // for loop. Så længe i er mindre end agentlisten, så plus i med en.
            // På den måde looper vi gennem vires array og får vist alle
            // de oprettede elementer i arraylisten med vores .ToString() metode. 
            for (int i = 0; i < agentArrayList.Count; i++)
            {
                ListBoxShow.Items.Add(agentArrayList[i].ToString());
            }
        }

        // Kode for vores onClick function til at 
        protected void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            // Varibler fra vores textbox til at skifte sprog samt oprette krypteret besked
            // Vi tager værdierne fra det, som der er indtastet i vores textbox
            string handler_name = TextBoxName0.Text;
            string handler_lang1 = TextBoxLang3.Text;
            string hanler_lang2 = TextBoxLang4.Text;
            //Foreach loop. For hvert pbjekt lavet af vores klasse secretagent som er gemt i vores arraylist
            foreach(SecretAgent x in agentArrayList)
                {
                // Hvis navnet i textbos handler er lig med at navn i vores arraylist
                if(handler_name == x.Name)
                {
                    // Så kan eksisterende lang1 og lang2 ændres til værdigerne indtastet i textbox. 
                    x.Lang1 = handler_lang1;
                    x.Lang2 = hanler_lang2;
                    ListBoxEncrypt.Items.Add(x.ToString());
                
                }
            }

            

        }

    }
    
}