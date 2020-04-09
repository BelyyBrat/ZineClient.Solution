﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZineClient.Models;

namespace ZineClient.Migrations
{
    [DbContext(typeof(ZineClientContext))]
    [Migration("20200408222538_DummyAccount")]
    partial class DummyAccount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ZineClient.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "0061f5ab-7a7d-467b-bff9-ad3abf81a694",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f6bbfe83-4995-44ce-95d9-75bb321baff0",
                            EmailConfirmed = false,
                            FirstName = "Foo",
                            LastName = "Bar",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "user@developer"
                        });
                });

            modelBuilder.Entity("ZineClient.Models.ApplicationUserOrganization", b =>
                {
                    b.Property<int>("ApplicationUserOrganizationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("OrganizationId");

                    b.HasKey("ApplicationUserOrganizationId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ApplicationUserOrganization");
                });

            modelBuilder.Entity("ZineClient.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<byte[]>("MainImageFile");

                    b.Property<string>("MainImageUrl");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.HasKey("OrganizationId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            OrganizationId = 1,
                            Description = "We are a small grassroots community of creators committed to bringing you high quality content for the current era",
                            MainImageUrl = "https://www.geniuscr8.com/wp-content/uploads/2018/07/Genius-Concept-Sample-Logo-2.jpg",
                            Name = "The Sample Org"
                        },
                        new
                        {
                            OrganizationId = 2,
                            Description = "Pasting (and cutting, copying, etc.) is the name of the game for this paper-turned-digital media project",
                            MainImageUrl = "https://turbologo.com/articles/wp-content/uploads/2018/03/prozrachniy-logo-1-1280x720.png",
                            Name = "Makers of Ctrl+V"
                        },
                        new
                        {
                            OrganizationId = 3,
                            Description = "We pride ourselves on transparency and keeping the public informed. Check out our West Seattle Connection blog",
                            MainImageUrl = "https://cdn.vox-cdn.com/thumbor/2KfYhzovz49NNJ5aBw9agDxWoAo=/0x0:4000x3000/1200x800/filters:focal(1541x1365:2181x2005)/cdn.vox-cdn.com/uploads/chorus_image/image/65976577/shutterstock_1386088199.0.jpg",
                            Name = "West Seattle Connection"
                        });
                });

            modelBuilder.Entity("ZineClient.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Body");

                    b.Property<byte[]>("MainImageFile");

                    b.Property<string>("MainImageUrl");

                    b.Property<DateTime>("Published");

                    b.Property<string>("Source");

                    b.Property<string>("Title");

                    b.HasKey("PostId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            MainImageUrl = "https://media.npr.org/assets/bakertaylor/covers/t/the-new-me/9780143133605_custom-032ec0143cbe2b6613d2f46cb11228fc7fa84521-s300-c85.jpg",
                            Published = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(8557),
                            Source = "https://www.npr.org/2019/03/19/704428358/the-new-me-is-meh-about-ambition-and-adulthood",
                            Title = "Sample Post"
                        },
                        new
                        {
                            PostId = 2,
                            Body = "'This story begins with the Adderall,' opens Casey Schwartz's Attention: A Love Story. In 2000, Schwartz was in college, struggling to write an essay, when a friend offered her a pill 'the deep bright blue of a cartoon sky' and her hand 'shot out to receive it.'Here already are the seeds of what is coming: It is not 'Adderall' but 'the Adderall,' not the serviceable 'take' or 'grab' but the sacramental 'receive.'Schwartz fell in love. Adderall was 'attention weaponized, slashing through procrastination and self-doubt, returning me to a place that felt almost like childhood, with its unclouded pleasures of rapt hours, lost in books and imagination. Childhood, but with a jittery amphetamine edge...'",
                            MainImageUrl = "https://media.npr.org/assets/bakertaylor/covers/a/attention/9781524747107_custom-5554b06219ed55f1cabc3e970c2bb37de6a89840-s300-c85.jpg",
                            Published = new DateTime(2020, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Source = "https://www.npr.org/2020/04/08/828800691/in-an-age-of-screens-looking-for-attention-in-all-the-wrong-places",
                            Title = "In An Age Of Screens, Looking For 'Attention' In All The Wrong Places"
                        },
                        new
                        {
                            PostId = 3,
                            Body = "The Russian poet Joseph Brodsky once said that prison is a lack of space counterbalanced by a surplus of time. Our current lockdown can't be compared to being locked up, but with so much surplus time on our hands, many of us are eager for stories that will help us escape endless thoughts of COVID-19. Here are three that did that for me: Unorthodox This desire for escape underlies the appeal of Unorthodox, the four-part Netflix series that has viewers whooshing through it in a single night. Loosely based on a memoir by Deborah Feldman, it stars Israeli actor Shira Haas as 19-year-old Esther 'Esty' Shapiro, a woman who flees her marriage and her tight Hasidic community in Williamsburg, Brooklyn. Esty jets off to Berlin, where a group of music students take her under their wing. Meanwhile, she's pursued by her husband, Yanky (Amit Rahav), and his cousin Moishe (Jeff Wilbusch), who's something of a thug.",
                            MainImageUrl = "https://media.npr.org/assets/img/2020/04/06/anika-molnar-netflix_wide-37dbf151aa711845cd3336cdacf929c135f1d46b-s800-c85.jpg",
                            Published = new DateTime(2020, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Source = "https://www.npr.org/2020/04/06/828085961/need-an-escape-try-unorthodox-baghdad-central-and-abigail",
                            Title = "Need An Escape? Try 'Unorthodox,' 'Baghdad Central' And 'Abigail'"
                        },
                        new
                        {
                            PostId = 4,
                            Body = "Rebecca Dinerstein Knight's strange and delightful second novel, Hex, opens with its protagonist in crisis. Nell Barber is an ex-doctoral student at Columbia; her lab, which studied toxins, has been disbanded after a student accidentally poisons herself, and now Nell is floating through New York, grief-stricken and in need of work. She's also profoundly lovesick for her dissertation advisor, a magnetic young botanist named Dr. Joan Kallas. Without Joan's 'absolutely necessary nearness,' Nell is undone. She describes herself as 'deleted.' She spends her time cooking up ways to continue her research without a lab; writing long letters to Joan in composition notebooks; and seeking beauty wherever she can find it.",
                            MainImageUrl = "https://media.npr.org/assets/bakertaylor/covers/h/hex/9781984877376_custom-d7f85cab68b5281986f54966f07ac251b2432495-s300-c85.jpg",
                            Published = new DateTime(2020, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Source = "https://www.npr.org/2020/04/04/826891969/charming-hex-insists-on-beauty-and-joy",
                            Title = "Charming 'Hex' Insists On Beauty And Joy"
                        },
                        new
                        {
                            PostId = 5,
                            Body = "Here's the West Seattle Bridge on Sept. 19, 2015. See any cracks? Nope. Photo by Patrick Robinson.",
                            MainImageUrl = "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/s960x960/92598824_10222383695444196_8978529166924185600_o.jpg?_nc_cat=105&_nc_sid=ca434c&_nc_oc=AQkbCoY2oCStEgnkHqeWuosOfw0dvbp3s3chQk5rzZ4Fzju5FzY5JwWcRndOnNy8PFbcv0AsljHNVgA1igwYzzhI&_nc_ht=scontent-sea1-1.xx&_nc_tp=7&oh=750b576c6a65f531de6ea44952a0b945&oe=5EB40642",
                            Published = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9033),
                            Source = "West Seattle Connection",
                            Title = "Bridge now"
                        },
                        new
                        {
                            PostId = 6,
                            Body = "Anyone on here that used to go to the Party House in White Center, sad to say that my Dad, Hurley Ring has passed away at the age of 94. He owned and ran the Party House for 36 years from 1952 to 1988. He loved his time running the store and meeting so many people, many of whom became good friends! He had a great run! Thanks to all of you who made it memorable for him!",
                            MainImageUrl = "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/92122080_3663086160399133_3531716169725640704_n.jpg?_nc_cat=108&_nc_sid=07e735&_nc_oc=AQl8p8W4In9MyKp78AZFWqbw9xOcEwKREc_6h852TyfizBZ3hUytBT0Ry8hKUqd4Ly6n9unf_2mFdwxHf9kVSY91&_nc_ht=scontent-sea1-1.xx&oh=5f2b1e72c1e7395fa239ec80d8529160&oe=5EB2EBC9",
                            Published = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9044),
                            Source = "West Seattle Connection",
                            Title = "Party House"
                        },
                        new
                        {
                            PostId = 7,
                            Body = "I saw this person on a high rise bicycle coming down Highland Park Way today. It’s always fun to see people doing interesting things like this, not to mention the skill of using a bus stop sign to hold yourself on a hill! EDIT: one of the commenters identified this person as Aaron from Aaron's Bicycle Repair in White Center. The website lists his shop as open. If you are in need of such services, be sure to keep his business in mind.",
                            MainImageUrl = "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/91850808_10218951980923965_7620497844079689728_n.jpg?_nc_cat=111&_nc_sid=ca434c&_nc_oc=AQnF1Hi8Gp2zOzX3mslL2f7Ni4toCHkAcbL0tuoHqy3DQ_cKgjnZeod8vZMKhSOgTe1Qbw-M-ZT_zoYu2wX8l7rx&_nc_ht=scontent-sea1-1.xx&oh=ab0167a841a066036d87af341e27f5c8&oe=5EB32C1C",
                            Published = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9049),
                            Source = "West Seattle Connection",
                            Title = "Bicycle Person"
                        },
                        new
                        {
                            PostId = 8,
                            Body = "I haven’t laughed so hard in weeks... not even all the memes can beat this. I was standing there laughing and he even came out to say hello! Thank you Psychic Barber!!",
                            MainImageUrl = "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/92678252_10158280722022417_8621941719081943040_n.jpg?_nc_cat=101&_nc_sid=ca434c&_nc_oc=AQmidwsOmbAFIvfNQ5Jy5uNfaNXM6HDM57L2Q8iM5-_zt2Xf06xvibM86Uxe1PwJzDYPjRb3pYGWXy0Jwe2gdlIp&_nc_ht=scontent-sea1-1.xx&oh=64aa052c2c292b33fbf25e5c0875ed43&oe=5EB3027C",
                            Published = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9053),
                            Source = "West Seattle Connection",
                            Title = "Psychic Barber"
                        },
                        new
                        {
                            PostId = 9,
                            Body = "Given the state of the West Seattle Bridge does anyone else think we should be revisiting the decision not to tunnel under the Duwamish for our light rail? Perhaps a tunnel for both traffic and light rail might make the project more cost effective given the cost we’re currently facing to repair a crumbling bridge, and building another huge bridge for light rail, and with the economic costs of having the bridge out of commission for an unknown period of time? *pic taken June 2019. My Son and I noticed them working on the bridge cracks throughout 2019",
                            MainImageUrl = "https://scontent-sea1-1.xx.fbcdn.net/v/t1.0-9/92531837_10221747110850778_7079577568193544192_n.jpg?_nc_cat=103&_nc_sid=ca434c&_nc_oc=AQnJfUCl5n_sEO61IK8JF1RsYkYdHURtBNbUrjd7PQig0PS7FYpF0A3r_2TK7ZrlGx2Dpg0NfOTiB_0Di6y1plYc&_nc_ht=scontent-sea1-1.xx&oh=041d6eb8b2b6608b92bea2c1515d80d8&oe=5EB3DD39",
                            Published = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(9057),
                            Source = "West Seattle Connection",
                            Title = "Our Bridge"
                        });
                });

            modelBuilder.Entity("ZineClient.Models.PostTag", b =>
                {
                    b.Property<int>("PostTagId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PostId");

                    b.Property<int>("TagId");

                    b.HasKey("PostTagId");

                    b.HasIndex("PostId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("ZineClient.Models.PostZine", b =>
                {
                    b.Property<int>("PostZineId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PostId");

                    b.Property<int>("ZineId");

                    b.HasKey("PostZineId");

                    b.HasIndex("PostId");

                    b.HasIndex("ZineId");

                    b.ToTable("PostZine");
                });

            modelBuilder.Entity("ZineClient.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ZineClient.Models.Zine", b =>
                {
                    b.Property<int>("ZineId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("IssueNumber");

                    b.Property<byte[]>("MainImageFile");

                    b.Property<string>("MainImageUrl");

                    b.Property<string>("Name");

                    b.Property<int>("OrganizationId");

                    b.Property<DateTime>("PublicationDate");

                    b.HasKey("ZineId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Zines");

                    b.HasData(
                        new
                        {
                            ZineId = 1,
                            Description = "The zine of your dreams",
                            IssueNumber = 1,
                            MainImageUrl = "https://cms-assets.tutsplus.com/uploads/users/114/posts/32493/image/Mockup1.jpg",
                            Name = "Ctrl+V",
                            OrganizationId = 2,
                            PublicationDate = new DateTime(2020, 4, 8, 15, 25, 37, 67, DateTimeKind.Local).AddTicks(9964)
                        },
                        new
                        {
                            ZineId = 2,
                            Description = "The zine of your dreams, remastered",
                            IssueNumber = 2,
                            MainImageUrl = "https://texlibris.lib.utexas.edu/wp-content/uploads/2020/02/17-01898_3600-712x1024.jpg",
                            Name = "Ctrl+V",
                            OrganizationId = 2,
                            PublicationDate = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(2973)
                        },
                        new
                        {
                            ZineId = 3,
                            Description = "The zine of your dreams, trilogy edition",
                            IssueNumber = 4,
                            MainImageUrl = "https://images.squarespace-cdn.com/content/v1/5b69d5843917eed82e6834fc/1537917947123-QPP10RP1SC469FXQXP45/ke17ZwdGBToddI8pDm48kHTjdXaoHj2XBS1xQ9Jx_M57gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z5QPOohDIaIeljMHgDF5CVlOqpeNLcJ80NK65_fV7S1Uei60Zpw-ZuEzVY2XSpngzHUNhdVwAOL_XMz32vi4iSsh9ymnU-gXScjHEMuNgenFw/The+Joy+003-Cover-spreads.jpg?format=2500w",
                            Name = "Ctrl+V",
                            OrganizationId = 2,
                            PublicationDate = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3000)
                        },
                        new
                        {
                            ZineId = 4,
                            Description = "The zine for when the zine of your dreams already existed",
                            IssueNumber = 1,
                            MainImageUrl = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/380a5783-bac6-4184-9776-270b1e3b6a1d/dchzmx3-4b7e18cb-02cb-41ce-a192-ccb57c77e763.png/v1/fill/w_1024,h_1453,q_80,strp/shindeku_zine_cover____by_neon_nuisance_dchzmx3-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTQ1MyIsInBhdGgiOiJcL2ZcLzM4MGE1NzgzLWJhYzYtNDE4NC05Nzc2LTI3MGIxZTNiNmExZFwvZGNoem14My00YjdlMThjYi0wMmNiLTQxY2UtYTE5Mi1jY2I1N2M3N2U3NjMucG5nIiwid2lkdGgiOiI8PTEwMjQifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.UfjaWa0T3nF6rngtM2Fg0mW036EwLWIC4eZKmuEH_U4",
                            Name = "Ctrl+C",
                            OrganizationId = 2,
                            PublicationDate = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3006)
                        },
                        new
                        {
                            ZineId = 5,
                            Description = "Asp.NET Core 101: A crash course",
                            IssueNumber = 1,
                            MainImageUrl = "https://dispozitivbooks.com/wp-content/uploads/2020/03/8.jpg",
                            Name = "Devs Digest",
                            OrganizationId = 1,
                            PublicationDate = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3010)
                        },
                        new
                        {
                            ZineId = 6,
                            Description = "Our unfiltered opinions on group projects, late nights, and quarantine blues",
                            IssueNumber = 2,
                            MainImageUrl = "https://pbs.twimg.com/media/ETy7wcJWsAEplrI.jpg",
                            Name = "Team Week in the making",
                            OrganizationId = 1,
                            PublicationDate = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3014)
                        },
                        new
                        {
                            ZineId = 7,
                            Description = "Though it's isolated from the rest of the city, West Seattle is an incredibly popular area, whether it's to live in or just to visit one of its hip neighborhoods.",
                            IssueNumber = 1,
                            MainImageUrl = "https://cdn.vox-cdn.com/thumbor/tyONoySTF3e4Qq64-86lCk9DdZA=/0x0:2500x1295/1200x900/filters:focal(751x398:1151x798)/cdn.vox-cdn.com/uploads/chorus_image/image/54721251/west_seattle_shutterstock.0.jpg",
                            Name = "About West Seattle",
                            OrganizationId = 3,
                            PublicationDate = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3018)
                        },
                        new
                        {
                            ZineId = 8,
                            Description = "The renovated West Seattle Branch opened April 3, 2004. At this Carnegie library, tall ceilings contribute to a sense of openness. Rich detailing and use of wood throughout the interior add to the warm, historic feel.",
                            IssueNumber = 2,
                            MainImageUrl = "https://pauldorpat.com/wp-content/uploads/2011/12/branches-color-postcard-web1.jpg?w=500&h=309",
                            Name = "West Seattle Library",
                            OrganizationId = 3,
                            PublicationDate = new DateTime(2020, 4, 8, 15, 25, 37, 70, DateTimeKind.Local).AddTicks(3022)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ZineClient.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ZineClient.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ZineClient.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ZineClient.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ZineClient.Models.ApplicationUserOrganization", b =>
                {
                    b.HasOne("ZineClient.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Organizations")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ZineClient.Models.Organization", "Organization")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ZineClient.Models.Organization", b =>
                {
                    b.HasOne("ZineClient.Models.ApplicationUser", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("ZineClient.Models.Post", b =>
                {
                    b.HasOne("ZineClient.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Posts")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("ZineClient.Models.PostTag", b =>
                {
                    b.HasOne("ZineClient.Models.Post", "Post")
                        .WithMany("Tags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ZineClient.Models.Tag", "Tag")
                        .WithMany("Posts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ZineClient.Models.PostZine", b =>
                {
                    b.HasOne("ZineClient.Models.Post", "Post")
                        .WithMany("Zines")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ZineClient.Models.Zine", "Zine")
                        .WithMany("Posts")
                        .HasForeignKey("ZineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ZineClient.Models.Zine", b =>
                {
                    b.HasOne("ZineClient.Models.Organization", "Organization")
                        .WithMany("Zines")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}