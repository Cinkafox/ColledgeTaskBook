using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ColledgeTaskBook
{
    public partial class MainPage : ContentPage
    {
         
        public MainPage(List<Category> categories = null,List<Book> books = null)
        {
            InitializeComponent();
            if(categories == null && books == null)
            {
                categories = new List<Category>();

                // fantasy
                List<Book> fantasybooks = new List<Book>
                {
                    new Book("Волшебник Чего-то", "", "https://cv6.litres.ru/pub/c/cover_max1500/16061264.jpg", "Это книга о юноше по имени Гед, которому судьбой предназначено стать одним из величайших героев Земноморья. Пройдя нелёгкий путь от сына простого деревенского кузнеца до могучего волшебника, он преодолеет множество трудностей и испытаний, встретит верных друзей, познает и радости, и горести этого мира... Но главное — он пройдёт до конца свой путь, не побоится встретиться с самым опасным врагом и обретёт свою подлинную сущность, станет собой!"),
                    new Book("Волшебник Земноморья", "", "https://cv6.litres.ru/pub/c/cover_max1500/16061264.jpg", "Это книга о юноше по имени Гед, которому судьбой предназначено стать одним из величайших героев Земноморья. Пройдя нелёгкий путь от сына простого деревенского кузнеца до могучего волшебника, он преодолеет множество трудностей и испытаний, встретит верных друзей, познает и радости, и горести этого мира... Но главное — он пройдёт до конца свой путь, не побоится встретиться с самым опасным врагом и обретёт свою подлинную сущность, станет собой!")
                };
                categories.Add(new Category("фэнтези", "", "https://aif-s3.aif.ru/images/016/556/37ab2e826a9cda48b13ec2daa6852a10.jpg", fantasybooks));

                // sciense
                List<Book> sciensebooks = new List<Book>{
                    new Book("Солярис (роман)", "", "https://img3.labirint.ru/rc/f50c5f2e804389d307159505fd372750/363x561q80/books44/431721/cover.jpg?1612970739", "Это книга о юноше по имени Гед, которому судьбой предназначено стать одним из величайших героев Земноморья. Пройдя нелёгкий путь от сына простого деревенского кузнеца до могучего волшебника, он преодолеет множество трудностей и испытаний, встретит верных друзей, познает и радости, и горести этого мира... Но главное — он пройдёт до конца свой путь, не побоится встретиться с самым опасным врагом и обретёт свою подлинную сущность, станет собой!")
                };
                categories.Add(new Category("наука", "", "https://mf.b37mrtl.ru/russian/images/2022.02/article/62013b3602e8bd7deb7a1f35.jpg", sciensebooks));

                // Detective
                List<Book> detectivebooks = new List<Book>{
                    new Book("Безмолвный пациент", "", "https://img2.labirint.ru/rcimg/7329d7cbed4332fe0af7e411d053f505/960x540/books69/681890/ph_001.jpg?1613050681", "Жизнь Алисии Беренсон кажется идеальной. Известная художница вышла замуж за востребованного модного фотографа. Она живет в одном из самых привлекательных и дорогих районов Лондона, в роскошном доме с большими окнами, выходящими в парк. Однажды поздним вечером, когда ее муж Габриэль возвращается домой с очередной съемки, Алисия пять раз стреляет ему в лицо. И с тех пор не произносит ни слова.\r\n\r\nОтказ Алисии говорить или давать какие-либо объяснения будоражит общественное воображение. Тайна делает художницу знаменитой. И в то время как сама она находится на принудительном лечении, цена ее последней работы – автопортрета с единственной надписью по-гречески «АЛКЕСТА» – стремительно растет.\r\n\r\nТео Фабер – криминальный психотерапевт. Он долго ждал возможности поработать с Алисией, заставить ее говорить. Но что скрывается за его одержимостью безумной мужеубийцей и к чему приведут все эти психологические эксперименты? Возможно, к истине, которая угрожает поглотить и его самого…\r\n\r\nАлекс писал «Безмолвного пациента» в то время как работал над сценарием фильма «Аферисты поневоле» с Умой Турман и Тимом Ротом в главных ролях. Именно Ума Турман предложила Михаэлидесу сделать главную героиню – Алисию – художницей. Писателю эта идея пришлась по душе: ведь героиня его любимого романа «Кошачий глаз» Маргарет Этвуд также была художницей. Как только он представил Алисию именно в этой профессии, она сразу «ожила».\r\n\r\nАлекс признается, что процесс написания «Безмолвного пациента» в одиночестве в кафе или в квартире был самым счастливым в его творческой жизни. «Просто работа над предложением, перемещение слов, поиск правильного синонима – все это делает меня очень счастливым», – говорит писатель.\r\n\r\nПрава на экранизацию принадлежат продюсерской компании Брэда Питта Plan B Entertainment, и Алекс отмечает, что заново пересоберет эту историю в сценарий.")
                };
                categories.Add(new Category("детектив", "", "https://avtoram.com/wp-content/uploads/2014/02/66.jpg", detectivebooks));


            }

            if(categories != null) 
            foreach(Category item in categories)
            {
                Frame f = appendListItem(item);
                TapGestureRecognizer t = new TapGestureRecognizer();
                t.Tapped += (s,e) =>
                {
                    Navigation.PushAsync(new MainPage(null, item.GetBooks()));
                };
                f.GestureRecognizers.Add(t);
            }

            if(books != null)
            foreach(Book item in books) 
            {
                Frame f = appendListItem(item);
                TapGestureRecognizer t = new TapGestureRecognizer();
                t.Tapped += (s,e) =>
                {
                    Navigation.PushAsync(new BookPage(item.getText()));
                };
                f.GestureRecognizers.Add(t);
            }

        }

        public Frame appendListItem(Item item)
        {
            Frame i = createListItem(item);
            Items.Children.Add(i);
            return i;
        }

        public Frame createListItem(Item item)
        {
            Frame frame = new Frame();
            frame.BackgroundColor = Color.FromHex("#224433");
            frame.Padding = 0;

            StackLayout stackLayout = new StackLayout();
            stackLayout.Orientation= StackOrientation.Horizontal;
            stackLayout.HorizontalOptions = LayoutOptions.StartAndExpand;

            Image image = new Image();
            image.Aspect = Aspect.AspectFill;
            image.HeightRequest = 80;
            image.WidthRequest = 120;
            image.Source = item.getImgdir();

            Label label = new Label();
            label.Text = item.getName();
            label.HorizontalOptions= LayoutOptions.Center;
            label.VerticalOptions= LayoutOptions.Center;

            stackLayout.Children.Add(image);
            stackLayout.Children.Add(label);
            

            frame.Content= stackLayout;


            return frame;
        }
    }


    public class Item
    {
        public string name;
        public string descritption;
        public string imgdir;

        public Item(string name, string description, string imgdir)
        {
            this.name = name;
            this.descritption = description;
            this.imgdir = imgdir;
        }

        public String getName()
        {
            return name;
        }
        public String getDescription()
        {
            return descritption;
        }
        public String getImgdir()
        {
            return imgdir;
        }

    }

    public class Category : Item
    {
        List<Book> books;

        public Category(string name, string descritption, string imgdir, List<Book> books) : base(name,descritption,imgdir)
        {
            this.books = books;
        }

        public List<Book> GetBooks()
        {
            return books;
        }
    }

    public class Book : Item
    {
        string text;
        public Book(string name, string description, string imgdir, string text) : base(name,description,imgdir)
        {
            this.text = text;
        }

        public String getText()
        {
            return text;
        }

    }
    
}
