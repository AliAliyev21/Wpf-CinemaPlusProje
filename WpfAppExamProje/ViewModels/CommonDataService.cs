using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppExamProje.Models;

namespace WpfAppExamProje.ViewModels
{
    public class CommonDataService
    {
        public ObservableCollection<Facilities> AllFacilities { get; set; }
        public ObservableCollection<Languages> AllLanguages { get; set; }
        public ObservableCollection<Movie> AllMovies { get; set; }
        public ObservableCollection<Hall> AllHalls { get; set; }
        public ObservableCollection<MovieTime> AllTimes { get; set; }

        public CommonDataService()
        {

            AllTimes = new ObservableCollection<MovieTime>
            {
                new MovieTime { DateTime = new DateTime(2023, 11, 27) },
                new MovieTime { DateTime = new DateTime(2023, 11, 28) },
                new MovieTime { DateTime = new DateTime(2023, 11, 29) },
            };

            AllHalls = new ObservableCollection<Hall>
            {
                new Hall{Hall1="Hall1" },
                new Hall{Hall2="Hall2" },
                new Hall{Hall3="Hall3" },
                new Hall{Hall4="Hall4" },
                new Hall{Hall5="Hall5" },
                new Hall{Hall6="Hall6" },
                new Hall{Hall7="Hall7" },
                new Hall{Hall8="Hall8" },
                new Hall{Hall9="Hall9" },
            };

            AllFacilities = new ObservableCollection<Facilities>
            {
                new Facilities{Name="Cinema"},
                new Facilities{Name="28 Mall"},
                new Facilities{Name="Ganjlik Mall"},
                new Facilities{Name="Deniz Mall"},
                new Facilities{Name="Amburan Mall"},
                new Facilities{Name="Sumgayit"},
                new Facilities{Name="Bakixanov Mall"},
                new Facilities{Name="Nakhchivan"},
            };

            AllLanguages = new ObservableCollection<Languages>
            {
                new Languages{Language="Language"},
                new Languages{Language="Ha русском"},
                new Languages{Language="In English"},
                new Languages{Language="Turkce"},
                new Languages{Language="Azerbaycanca"},
            };

            AllMovies = new ObservableCollection<Movie>
            {
                new Movie
                {
                    Name="Napoleon",
                    TralierUrl="https://www.youtube.com/watch?v=LIsfMO5Jd_w",
                    DateTime = new DateTime(2023, 11, 27),
                    Image="/Images/napoleon.jpg",
                    FormatRu="/Images/russia.png",
                    FormatEn="/Images/english.png",
                    FormatTr="/Images/turkey.png",
                    Format2D="/Images/twod.png",
                    FormatAzeSub="/Images/azsub.png",
                    AgeRestrictions="/Images/12+Icon.png",
                    Language="Language,Ha русском,Turkce,In English",
                    Location="28 Mall                       ,Cinema",
                    Formats="/Images/english.png",
                    OnScreens="23.11.2023 - 20.12.2023",
                    Country=" UK, USA",
                    Director="Ridli Skot",
                    Actors="Joaquin Phoenix, Vanessa Kirby, Ludivine Sagnier",
                    Duration="175 minutes",
                    Genre="biography, military, drama, history",
                    Age="18+",
                    Sesions="10:00",
                    Hall="Hall 1",
                    Price=10.00,
                    About="The story of Bonaparte's difficult path to" +
                    " power through the prism of his volatile relationship" +
                    " with his only true love, Josephine."
                },
                new Movie
                {
                    Name="Catastrophe",
                    TralierUrl="https://www.youtube.com/watch?v=MHkVZYK0rpQ",
                    DateTime = new DateTime(2023, 11, 27),
                    Image="/Images/catastrop.jpg",
                    FormatRu="/Images/russia.png",
                    FormatEn="/Images/english.png",
                    FormatTr="/Images/turkey.png",
                    Format2D="/Images/twod.png",
                    FormatAzeSub="/Images/azsub.png",
                    AgeRestrictions="/Images/18+Icon.png",
                    Language="Language,Ha русском",
                    Location="Deniz Mall                   ,Cinema,",
                    Formats="/Images/russia.png",
                    OnScreens="16.11.2023 - 06.12.2023",
                    Country="France, Belgium",
                    Director="Just Filippo",
                    Actors="Guillaume Canet, Laetitia Doche, Patience Munchenbach",
                    Duration="115 minutes",
                    Genre="fantastic, thriller, action",
                    Age="18+",
                    Sesions="20:00",
                    Hall="Hall 3",
                    Price=8.00,
                    About="All over the world there are abnormal cases of" +
                    " acid rain, destroying all living things. Fifteen-year-old" +
                    " Selma and her parents find themselves at the center of a deadly" +
                    " disaster. Together they will have to combine all their strength to" +
                    " escape the universal threat and survive the apocalypse."
                },
                new Movie
                {
                    Name="Much Love",
                    TralierUrl="https://www.youtube.com/watch?v=B8Y0LaC07ok",
                    DateTime = new DateTime(2023, 11, 27),
                    Image="/Images/cokawk.jpg",
                    FormatRu="/Images/russia.png",
                    FormatEn="/Images/english.png",
                    FormatTr="/Images/turkey.png",
                    Format2D="/Images/twod.png",
                    FormatAzeSub="/Images/azsub.png",
                    AgeRestrictions="/Images/12+Icon.png",
                    Language="Language,Turkce",
                    Location="Amburan Mall                    ,Cinema",
                    Formats="/Images/turkey.png",
                    OnScreens=" 09.11.2023 - 29.11.2023",
                    Country="Turkiye",
                    Director="Kivanch Baruonu",
                    Actors="Hasan Jan Kaya, Bushra Pekin, Tevhide Shebnem Sonmez",
                    Duration="115 minutes",
                    Genre="comedy",
                    Age="16+",
                    Sesions="15:00",
                    Hall="Hall 4",
                    Price=12.00,
                    About="The film tells the story of a man who is trying to" +
                    " realize his dreams and win the heart of the love of his life." +
                    " Joshkun is a young man whose biggest dream is to become a comedian " +
                    "and make films. Joshkun, who along with his older brother Irfan earns" +
                    " a living by selling pirated films, takes a completely different turn when " +
                    "he meets Ayla, the love of his life. Joshkun, who is writing a script and" +
                    " trying to realize his dreams of cinema, his greatest passion, is also trying" +
                    " to win Ayla's heart."
                },
                new Movie
                {
                    Name="Five Nights at Freddy's",
                    TralierUrl="https://www.youtube.com/watch?v=Z_T0o5uNrlY",
                    DateTime = new DateTime(2023, 11, 28),
                    Image="/Images/fivenights.jpg",
                    FormatRu="/Images/russia.png",
                    FormatEn="/Images/english.png",
                    FormatTr="/Images/turkey.png",
                    Format2D="/Images/twod.png",
                    FormatAzeSub="/Images/azsub.png",
                    AgeRestrictions="/Images/18+Icon.png",
                    Language="Language,Ha русском",
                    Location="Bakixanov Mall                      ,Cinema",
                    Formats="/Images/russia.png",
                    OnScreens="26.10.2023 - 29.11.2023",
                    Country="USA",
                    Director="Emma Tammi",
                    Actors="Matthew Lillard, Josh Hutcherson, Mary Stewart Masterson",
                    Duration="125 minutes",
                    Genre="horror",
                    Age="18+",
                    Sesions="17:00",
                    Hall="Hall 2",
                    Price=10.00,
                    About="Mike Schmidt takes a job as a security guard at Freddy " +
                    "Fazbear's Pizza, a once successful but now abandoned family" +
                    " entertainment center. On his first night on the job, he realizes" +
                    " that the night shift will not be so easy to endure."
                },
                new Movie
                {
                    Name="Hozu Dayə",
                    TralierUrl="https://www.youtube.com/watch?v=oYtgTke_bvk",
                    DateTime = new DateTime(2023, 11, 27),
                    Image="/Images/hozu.png",
                    FormatRu="/Images/Aze.jpg",
                    FormatEn="/Images/english.png",
                    FormatTr="/Images/turkey.png",
                    Format2D="/Images/twod.png",
                    FormatAzeSub="/Images/azsub.png",
                    AgeRestrictions="/Images/12+Icon.png",
                    Language="Language,Azerbaycanca",
                    Location="28 Mall                        ,Cinema",
                    Formats="/Images/Aze.jpg",
                    OnScreens="01.11.2023 - 20.12.2023",
                    Country="Azerbaijan",
                    Director="Ilham Yasharoghlu",
                    Actors="Majid Huseynov, Zemfira Abdulsamadova, Agil M. Guliyev, Samir Aleskerov, Tarlan Nuryashar",
                    Duration="95 minutes",
                    Genre="comedy",
                    Age="12+",
                    Sesions="16:00",
                    Hall="Hall 7",
                    Price=6.00,
                    About="Khozu promises his mother that he will work for any job she" +
                    " chooses in the newspaper. An ad \"Needing a nanny for an elderly" +
                    " woman\" appears. He keeps his promise and now he has to endure all the " +
                    "old woman's whims. She also tries different ways to drive him out of the house."
                },
                new Movie
                {
                    Name="The Marvels",
                    TralierUrl="https://www.youtube.com/watch?v=uwmDH12MAA4",
                    DateTime = new DateTime(2023, 11, 27),
                    Image="/Images/marvel.jpg",
                    FormatRu="/Images/russia.png",
                    FormatEn="/Images/english.png",
                    FormatTr="/Images/turkey.png",
                    Format2D="/Images/twod.png",
                    FormatAzeSub="/Images/azsub.png",
                    AgeRestrictions="/Images/12+Icon.png",
                    Language="Language,Ha русском,In English",
                    Location="Ganjlik Mall                     ,Cinema",
                    Formats="/Images/russia.png",
                    OnScreens="09.11.2023 - 13.12.2023",
                    Country="USA",
                    Director="Nia DaCosta",
                    Actors="Brie Larson, Samuel L. Jackson, Zavi Ashton",
                    Duration="120 minutes",
                    Genre=" fantasy, action, adventure",
                    Age="12+",
                    Sesions="19:00",
                    Hall="Hall 6",
                    Price=12.00,
                    About="Carol Danvers regains her lost identity, taken away by" +
                    " the Kree tyrants, and takes revenge on the Supreme Intelligence." +
                    " However, unintended consequences lead to a destabilized universe." +
                    " When she passes through a wormhole that would lead her to a Kree" +
                    " revolutionary, her powers become intertwined with the abilities of" +
                    " Jersey City superfan Kamala Khan, known as Ms. Marvel, as well as" +
                    " Carol's niece, Monica Rambeau (an agent of the S.W.O.R.D.)"
                },
                new Movie
                {
                    Name="The Hunger Games: The Ballad of Songbirds",
                    TralierUrl="https://www.youtube.com/watch?v=NxW_X4kzeus",
                    DateTime = new DateTime(2023, 11, 27),
                    Image="/Images/thehunger.jpg",
                    FormatRu="/Images/russia.png",
                    FormatEn="/Images/english.png",
                    FormatTr="/Images/turkey.png",
                    Format2D="/Images/twod.png",
                    FormatAzeSub="/Images/azsub.png",
                    AgeRestrictions="/Images/18+Icon.png",
                    Language="Language,Ha русском",
                    Location="Nakhchivan                    ,Cinema",
                    Formats="/Images/russia.png",
                    OnScreens="16.11.2023 - 13.12.2023",
                    Country="USA",
                    Director=" Francis Lawrence",
                    Actors="Rachel Zegler, Tom Blyth, Hunter Schafer",
                    Duration="170 minutes",
                    Genre="fantasy, action, thriller, drama, adventure",
                    Age="16+",
                    Sesions="21:00",
                    Hall="Hall 5",
                    Price=16.00,
                    About="With the 10th annual Hunger Games approaching," +
                    " young Snow is dismayed when he is assigned to mentor" +
                    " Lucy Gray Baird, a tribune girl from impoverished District " +
                    "12. But after Lucy Gray grabs the attention of all of Panem " +
                    "by singing defiantly during the harvest ceremony, Snow thinks," +
                    " that can turn the tide in your favor. Combining their showman" +
                    " instincts with their political savvy, "
                },
                new Movie
                {
                    Name="Wish",
                    TralierUrl="https://www.youtube.com/watch?v=oyRxxpD3yNw",
                    DateTime = new DateTime(2023, 11, 28),
                    Image="/Images/wishsite.jpg",
                    FormatRu="/Images/russia.png",
                    FormatEn="/Images/english.png",
                    FormatTr="/Images/turkey.png",
                    Format2D="/Images/twod.png",
                    FormatAzeSub="/Images/azsub.png",
                    AgeRestrictions="/Images/12+Icon.png",
                    Language="Language,Ha русском,In English,Turkce",
                    Location="Ganjlik Mall                 ,Cinema",
                    Formats="/Images/turkey.png",
                    OnScreens=" 23.11.2023 - 20.12.2023",
                    Country="USA",
                    Director="Chris Buck, Von Weerasuntorn",
                    Actors="Chris Pine, Alan Tudyk, Ariana DeBos",
                    Duration="105 minutes",
                    Genre="cartoon, fantasy, comedy, adventure, family",
                    Age="6+",
                    Sesions="13:00",
                    Hall="Hall 9",
                    Price=7.00,
                    About="Asha is a witty idealist who makes a wish so strong" +
                    " that it is answered by a cosmic force - a small ball of" +
                    " boundless energy called the Star. Together, Asha and Star " +
                    "confront the most formidable enemy - the ruler of Rosas, King" +
                    " Magnifico. By protecting her loved ones, Asha proves that" +
                    " when the will of one brave person is combined with the" +
                    " magic of the stars, amazing things can happen."
                },
                new Movie
                {
                    Name="Zir-i cin 2",
                    TralierUrl="https://www.youtube.com/watch?v=d6IHPk_WUzA",
                    DateTime = new DateTime(2023, 11, 28),
                    Image="/Images/ziricin.jpg",
                    FormatRu="/Images/russia.png",
                    FormatEn="/Images/english.png",
                    FormatTr="/Images/turkey.png",
                    Format2D="/Images/twod.png",
                    FormatAzeSub="/Images/azsub.png",
                    AgeRestrictions="/Images/18+Icon.png",
                    Language="Language,Turkce",
                    Location="Amburan Mall                   ,Cinema",
                    Formats="/Images/turkey.png",
                    OnScreens="09.11.2023 - 06.12.2023\r\n",
                    Country="Turkiye",
                    Director="Burak Kuchuk",
                    Actors="Ekrem Kayhan, Feyza Ayan, Tahsin Majit",
                    Duration="105 minutes",
                    Genre="horror",
                    Age="18+",
                    Sesions="23:00",
                    Hall="Hall 8",
                    Price=20.00,
                    About="Tariq finds Yusuf Khoja to investigate the events" +
                    " with demons that are said to have happened in his " +
                    "village Kanlybicki. Khoja Yusuf uncovered many evil deeds" +
                    " and saved many people from these deeds. They take " +
                    "measures to expose the curse of the village leader's" +
                    " daughter Eli Rza, and at Tariq's request, they decide to" +
                    " film everything. The event they experienced" +
                    " was recorded as demonic possession."
                },
            };
        }
    }
}
