using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ProjectCS.Models;

namespace ProjectCS.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            if (!(context.Users.Any(u => u.Id == "3uuU5rWQakmGDiDaDcUM")))
            {
                var userToInsert = new ApplicationUser
                {
                    Id = "3uuU5rWQakmGDiDaDcUM",
                    UserName = "norola@gmail.com",
                    FirstName = "Ola",
                    LastName = "Nordmann"
                };
                userManager.Create(userToInsert, "Password@123");
            }
            if (!(context.Users.Any(u => u.Id == "3uuU5rWQakmGDiDaDcUA")))
            {
                var userToInsert1 = new ApplicationUser
                {
                    Id = "3uuU5rWQakmGDiDaDcUA",
                    UserName = "lasse@arnesen.com",
                    FirstName = "Lasse",
                    LastName = "Arnesen"
                };
                userManager.Create(userToInsert1, "Password@123");
            }
            if (!(context.Users.Any(u => u.Id == "3uuU5rWQakmGDiDaDcUB")))
            {
                var userToInsert2 = new ApplicationUser
                {
                    Id = "3uuU5rWQakmGDiDaDcUB",
                    UserName = "ole@schreuder.com",
                    FirstName = "Ole Fredrik",
                    LastName = "Schreuder"
                };
                userManager.Create(userToInsert2, "Password@123");
            }

            if (!(context.Users.Any(u => u.Id == "3uuU5rWQakmGDiDaDcUC")))
            {
                var userToInsert3 = new ApplicationUser
                {
                    Id = "3uuU5rWQakmGDiDaDcUC",
                    UserName = "espen@ronning.com",
                    FirstName = "Espen",
                    LastName = "Rønning"
                };
                userManager.Create(userToInsert3, "Password@123");
            }

            if (!(context.Users.Any(u => u.Id == "3uuU5rWQakmGDiDaDcUD")))
            {
                var userToInsert4 = new ApplicationUser
                {
                    Id = "3uuU5rWQakmGDiDaDcUD",
                    UserName = "morten@hogseth.com",
                    FirstName = "Morten",
                    LastName = "Høgset"
                };
                userManager.Create(userToInsert4, "Password@123");
            }

            if (!context.Users.Any(u => u.Id == "3uuU5rWQakmGDiDaDcUE"))
            {
                var userToInsert5 = new ApplicationUser
                {
                    Id = "3uuU5rWQakmGDiDaDcUE",
                    UserName = "hans@waadeland.com",
                    FirstName = "Hans Fredric",
                    LastName = "Waadeland"
                };
                userManager.Create(userToInsert5, "Password@123");
            }

            if (!(context.Users.Any(u => u.Id == "3uuU5rWQakmGDiDaDcUF")))
            {
                var userToInsert6 = new ApplicationUser
                {
                    Id = "3uuU5rWQakmGDiDaDcUF",
                    UserName = "yassin@ferrhousse.com",
                    FirstName = "Yassin",
                    LastName = "Ferrhousse"
                };
                userManager.Create(userToInsert6, "Password@123");
            }

            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Alan Turing: The Enigma",
                    Description =
                        "Alan Turing (1912-54) was a British mathematician who made history. His breaking of the German U-boat Enigma cipher in World War II ensured Allied-American control of the Atlantic. But Turing's vision went far beyond the desperate wartime struggle. Already in the 1930s he had defined the concept of the universal machine, which underpins the computer revolution. In 1945 he was a pioneer of electronic computer design. But Turing's true goal was the scientific understanding of the mind, brought out in the drama and wit of the famous \"Turing test\" for machine intelligence and in his prophecy for the twenty-first century. Drawn in to the cockpit of world events and the forefront of technological innovation, Alan Turing was also an innocent and unpretentious gay man trying to live in a society that criminalized him. In 1952 he revealed his homosexuality and was forced to participate in a humiliating treatment program, and was ever after regarded as a security risk. His suicide in 1954 remains one of the many enigmas in an astonishing life story.",
                    Genre = "Biography",
                    Language = "English",
                    CreatedAt = new DateTime(2015, 6, 24),
                    EstimatedCost = 6000,
                    CoverUrl = "/Data/Projects/1/cover/cover.png",
                    CoverUrlSmall = "/Data/Projects/1/cover/coverSmall.png"
                },
                new Project
                {
                    Title = @"hitchhiker's guide to the galaxy",
                    Description =
                        "The first radio series comes from a proposal called The Ends of the Earth: six self-contained episodes, all ending with Earth's being destroyed in a different way. While writing the first episode, Adams realized that he needed someone on the planet who was an alien to provide some context, and that this alien needed a reason to be there. Adams finally settled on making the alien a roving researcher for a wholly remarkable book named The Hitchhiker's Guide to the Galaxy. As the first radio episode's writing progressed, the Guide became the centre of his story, and he decided to focus the series on it, with the destruction of Earth being the only hold-over. Adams claimed that the title came from a 1971 incident while he was hitchhiking around Europe as a young man with a copy of the Hitch-hiker's Guide to Europe book, and while lying drunk in a field near Innsbruck with a copy of the book and looking up at the stars, thought it would be a good idea for someone to write a hitchhiker's guide to the galaxy as well. However, he later claimed that he had told this story so many times that he had forgotten the incident itself, and only remembered himself telling the story. His friends are quoted as saying that Adams mentioned the idea of hitch-hiking around the galaxy to them while on holiday in Greece in 1973. Adams's fictional Guide is an electronic guidebook to the Milky Way galaxy, originally published by Megadodo Publications, one of the great publishing houses of Ursa Minor Beta. The narrative of the various versions of the story are frequently punctuated with excerpts from the Guide. The voice of the Guide (Peter Jones in the first two radio series and TV versions, later William Franklyn in the third, fourth and fifth radio series, and Stephen Fry in the movie version), also provides general narration.",
                    Genre = "Sci-fi",
                    Language = "English",
                    CreatedAt = new DateTime(2016, 4, 27),
                    EstimatedCost = 9500,
                    CoverUrl = "/Data/Projects/2/cover/cover.png",
                    CoverUrlSmall = "/Data/Projects/2/cover/coverSmall.png",
                    IsPublic = true
                },
                new Project
                {
                    Title = @"starship troopers",
                    Description =
                        @"Heinlein graduated from the U.S. Naval Academy in 1929, and served on active duty in the U.S. Navy for five years. He served on the then-new aircraft carrier USS Lexington in 1931, and as a naval lieutenant aboard the destroyer USS Roper between 1933 and 1934, until he was forced to leave the Navy because of pulmonary tuberculosis. Heinlein never served in active combat while a Navy officer and he was a civilian during World War II doing research and development at the Philadelphia Navy Yard.According to Heinlein, his desire to write Starship Troopers was sparked by the publication of a newspaper advertisement placed by the National Committee for a Sane Nuclear Policy on April 5, 1958 calling for a unilateral suspension of nuclear weapon testing by the United States. In response, Robert and Virginia Heinlein created the small Patrick Henry League in an attempt to create support for the U.S. nuclear testing program. Heinlein found himself under attack both from within and outside the science fiction community for his views. Heinlein used the novel to clarify and defend his military and political views at the time.",
                    Genre = "Sci-fi",
                    Language = "English",
                    CreatedAt = new DateTime(2017, 4, 27),
                    EstimatedCost = 500,
                    CoverUrl = "/Data/Projects/3/cover/cover.png",
                    CoverUrlSmall = "/Data/Projects/3/cover/coverSmall.png"
                },
                new Project
                {
                    Title = @"Forever war",
                    Description =
                        @"William Mandella is a physics student conscripted for an elite task force in the United Nations Exploratory Force being assembled for a war against the Taurans, an alien species discovered when they apparently suddenly attacked human colonists' ships. The UNEF ground troops are sent out for reconnaissance and revenge.The elite recruits have IQs of 150 and above, are highly educated, healthy and fit. Training is gruelling – first on Earth, in Missouri, and later on a fictional planet called Charon beyond Pluto (written before the discovery of the actual planetoid). Several of the recruits are killed during training, due to the extreme environments and the use of live weapons. The new soldiers then depart for action, traveling via interconnected 'collapsars' that allow ships to cover thousands of light-years in a split second. However, traveling to and from the collapsars at near-lightspeed has massive relativistic effects.Their first encounter with Taurans on a planet orbiting Epsilon Aurigae turns into a post-hypnotically suggested massacre, with the unresisting enemy wiped out. This first expedition, beginning in 1997, lasted only two years from the soldier's perspective, but due to time dilation, upon return to Earth decades have passed. On the long way home, the soldiers experience future shock first-hand, as the Taurans employ increasingly advanced weaponry against them while they do not have the chance to re-arm.",
                    Genre = "War",
                    Language = "English",
                    CreatedAt = new DateTime(2017, 3, 20),
                    EstimatedCost = 500,
                    CoverUrl = "/Data/Projects/4/cover/cover.png",
                    CoverUrlSmall = "/Data/Projects/4/cover/coverSmall.png"
                },
                new Project
                {
                    Title = @"Fifty  shades of gray",
                    Description =
                        @"Fifty Shades of Grey is a 2011 erotic romance novel by British author E. L. James. It is the first installment in the Fifty Shades trilogy that traces the deepening relationship between a college graduate, Anastasia Steele, and a young business magnate, Christian Grey. It is notable for its explicitly erotic scenes featuring elements of sexual practices involving bondage/discipline, dominance/submission, and sadism/masochism (BDSM). Originally self-published as an ebook and a print-on-demand, publishing rights were acquired by Vintage Books in March 2012. The second and third volumes, Fifty Shades Darker and Fifty Shades Freed, were published in 2012. Fifty Shades of Grey has topped best-seller lists around the world, including those of the United Kingdom and the United States. The series has sold over 100 million copies worldwide and been translated into 52 languages, and set a record in the United Kingdom as the fastest-selling paperback of all time.Critical reception of the book, however, has tended toward the negative, with the quality of its prose generally seen as poor. Universal Pictures and Focus Features produced a film adaptation, which was released on 13 February 2015 and also received generally unfavorable reviews.",
                    Genre = "Erotica",
                    Language = "English",
                    CreatedAt = new DateTime(2015, 3, 20),
                    EstimatedCost = 52,
                    CoverUrl = "/Data/Projects/5/cover/cover.png",
                    CoverUrlSmall = "/Data/Projects/5/cover/coverSmall.png"
                },
                new Project
                {
                    Title = @"Harry Potter",
                    Description =
                        @"Harry Potter er en serie på sju svært populære fantasy-romaner skrevet for barn, ungdom og voksne av den britiske forfatteren J.K. Rowling. Bøkene ble kåret til de beste ungdomsbøkene gjennom tidene av NPRs lyttere i 2012[1]. Bøkene ble første gang utgitt mellom 1997 og 2007. Harry Potter-serien har med et samlet salg på over 300 millioner bøker på i alt 60 språk oppnådd en utbredelse, kommersiell suksess og kulturell status ingen andre barnebøker tidligere har oppnådd. På engelsk blir Harry Potter-bøkene utgitt av forlagene Bloomsbury (Storbritannia), Scholastic Press (USA), Allen & Unwin (Australia) og Raincoast Books (Canada). I Norge har de blitt oversatt av Torstein Bugge Høverstad og utgitt av Cappelen Damm. Bøkene handler om den foreldreløse trollmanns-gutten Harry Potter og hans kamp mot den onde trollmannen Voldemort som drepte foreldrene hans da han var spebarn. Bokserien følger Harry fra han er elleve til han blir 37 år, og hver bok har skoleåret på Galtvort høyere skole for hekseri og trolldom. Rowling skaper et univers fullt av magiske vesner som eksisterer skjult for vanlige mennesker, også kalt gomper. Bøkene er lange og handlingsmettede og inneholder humor, spenning og tildels voldsom dramatikk. Med sin underholdende handling og sine fengslende figurer er bokserien lovprist for å oppmuntre barn til å lese, men også fått kritikk fra enkelte kristne miljøer, på grunn av tilstedeværelsen av magi og onde, ikke-kristne krefter. Utgivelsene av bøkene har fulgt en godt regissert og annonsert framdriftsplan. Den siste boka i serien, Harry Potter og dødstalismanene, ble lansert på engelsk den 21. juli 2007, og på norsk den 1. desember 2007. Den første romanen, Harry Potter og de vises stein ble lansert i 1997 i engelsk versjon og i 1999 i norsk versjon, og den nest siste boken, Harry Potter og Halvblodsprinsen, ble lansert i 2005. Alle bøkene er filmatisert. Det ble bestemt at Harry Potter og Dødstalismanene skulle deles i to deler, og den første filmen hadde premiere 12. november 2010, mens den andre og siste delen hadde premiere 15. juli 2011.",
                    Genre = "Adventure",
                    Language = "Norsk",
                    CreatedAt = new DateTime(2018, 3, 20),
                    EstimatedCost = 5555,
                    CoverUrl = "/Data/Projects/6/cover/cover.png",
                    CoverUrlSmall = "/Data/Projects/6/cover/coverSmall.png"
                }
            };

            projects.ForEach(ps => context.Projects.AddOrUpdate(p => p.Id, ps));
            context.SaveChanges();
        }
    }
}
