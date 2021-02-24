using System.Collections.Generic;
using System.Windows.Forms;

namespace NoSQLProject
{
    class SearchTickets
    {
        private List<ListViewItem> items;
        private ListView listViewTickets;
        private ListView allTickets;

        /*
         * Search Tickets
         * Individual part by Cosmin Ilie (645976)
         * 
         * 
         * How to use it:
         * You can search for a single word (e.g. cosmin, closed, open, etc...)
         * You can search for a word OR another word (e.g. cosmin | egehan) (searches for all tickets that have one or the other)
         * You can search for a word AND another word (e.g. cosmin & closed) (searches for all tickets that have both)
         * 
         */
        public SearchTickets(TextBox searchBox, ListView listViewTickets, ListView allTickets)
        {
            this.listViewTickets = listViewTickets;
            this.allTickets = allTickets;
            string[] searchBoxOptions = searchBox.Text.Split(' ');
            items = new List<ListViewItem>();


            /*
             * if searchBoxOptions has a size bigger or equal than 3, then there is either an OR or an AND
             * if the middle symbol is '|' then we execute the code for OR
             * if the middle symbol is '&' then we execute the code for AND
             * if the searchBoxOptions.Length is less than 3, then we take the whole search box as a single word
             */
            if (searchBoxOptions.Length >= 3)
            {
                if (searchBoxOptions[1] == "|") //for OR
                {
                    foreach (ListViewItem item in allTickets.Items)
                    {
                        for (int i = 0; i < searchBoxOptions.Length; i++)
                        {
                            if (i == 1) continue;
                            CheckIfSubitemContainsText(item, searchBoxOptions[i]);
                        }
                    }
                }
                else if (searchBoxOptions[1] == "&") //for AND
                    CheckIfSubitemContainsBothFilters(searchBoxOptions);
            }
            else
            {
                
                foreach (ListViewItem item in allTickets.Items) //for single word
                    CheckIfSubitemContainsText(item, searchBox.Text);
            }

            FillTicketList();

        }

        // this checks if that row contains the given text, if it does, it adds it to the list to display
        private void CheckIfSubitemContainsText(ListViewItem item, string text)
        {

            for (int j = 0; j < item.SubItems.Count; j++)
                if (item.SubItems[j].Text.ToLower().Contains(text.ToLower()))
                {
                    if (!items.Contains(item))
                        items.Add(item);
                    break;
                }
        }

        //fills the tickets list with the new items
        private void FillTicketList()
        {
            listViewTickets.Items.Clear();
            foreach (ListViewItem item in items)
                listViewTickets.Items.Add((ListViewItem)item.Clone());
        }


        //this is for the AND filter
        private void CheckIfSubitemContainsBothFilters(string[] searchBoxOptions)
        {
            foreach (ListViewItem item in allTickets.Items)
            {
                for (int i = 0; i < searchBoxOptions.Length; i++)
                {
                    bool containsFirst = false;
                    if (i == 1) continue; // searchBoxOptions[1] is the & sign, we skip it

                    for (int j = 0; j < item.SubItems.Count; j++)
                    {
                        if (item.SubItems[j].Text.ToLower().Contains(searchBoxOptions[i].ToLower())) //check if it contains any of the words provided
                            containsFirst = true;
                        else if (item.SubItems[j].Text.ToLower().Contains(searchBoxOptions[2].ToLower()))
                        {
                            if (containsFirst) //if it contains the first word, check if it also contains the second
                            {
                                if (!items.Contains(item))
                                    items.Add(item);
                                break;

                            }
                        }

                    }

                }
            }
        }
    }
}
