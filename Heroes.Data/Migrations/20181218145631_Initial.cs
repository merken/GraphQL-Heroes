using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Heroes.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Advantage = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    PlotSummary = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroAbilities",
                columns: table => new
                {
                    HeroId = table.Column<int>(nullable: false),
                    AbilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroAbilities", x => new { x.HeroId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_HeroAbilities_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeroAbilities_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SecretIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    HeroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecretIdentities_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Advantage = table.Column<double>(nullable: false),
                    HeroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Heroes_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LeaderId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Heroes_LeaderId",
                        column: x => x.LeaderId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponAbilities",
                columns: table => new
                {
                    WeaponId = table.Column<int>(nullable: false),
                    AbilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponAbilities", x => new { x.WeaponId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_WeaponAbilities_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeaponAbilities_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => new { x.TeamId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_TeamMembers_Heroes_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Heroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "Advantage", "Name" },
                values: new object[,]
                {
                    { 1, 50.0, "Super Strength" },
                    { 21, 10.0, "Philanthropist" },
                    { 20, 10.0, "Playboy" },
                    { 19, 10.0, "Billionaire" },
                    { 18, 99.0, "Genius" },
                    { 17, 10.0, "Ability to cling to any surface" },
                    { 16, 10.0, "Spider sense" },
                    { 15, 10.0, "Manipulation of Space and Time" },
                    { 14, 10.0, "Mastery of Magic" },
                    { 12, 10.0, "Weather Manipulation" },
                    { 13, 10.0, "Vibranium claws" },
                    { 10, 100.0, "Invulnerability" },
                    { 9, 15.0, "Energy repolsors" },
                    { 8, 15.0, "Super healing" },
                    { 7, 15.0, "Regenerative life support" },
                    { 6, 15.0, "Flight" },
                    { 5, 75.0, "Genius Intellect" },
                    { 4, 50.0, "Super Agility" },
                    { 3, 50.0, "Super Stamina" },
                    { 2, 50.0, "Super Speed" },
                    { 11, 180.0, "Electric Manipulation" }
                });

            migrationBuilder.InsertData(
                table: "Heroes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 7, "Dr. Bruce Banner lives a life caught between the soft-spoken scientist he’s always been and the uncontrollable green monster powered by his rage.", "Hulk" },
                    { 10, "James Buchanan “Bucky” Barnes enlists to fight in World War II, but eventually literally falls in battle. Unfortunately, the evil Arnim Zola recovers him and erases his memory, turning him into a highly-trained assassin called the Winter Soldier.", "Winter Soldier" },
                    { 9, "When ex-criminal Scott Lang turned to his illicit skills in order to save his daughter’s life, he unexpectedly became the size-shifting, insect-commanding Super Hero known as Ant-Man!", "Ant-Man" },
                    { 8, "Bitten by a radioactive spider, Peter Parker’s arachnid abilities give him amazing powers he uses to help others, while his personal life continues to offer plenty of obstacles.", "Spider-Man" },
                    { 6, "Formerly a renowned surgeon, Doctor Stephen Strange now serves as the Sorcerer Supreme—Earth’s foremost protector against magical and mystical threats.", "Dr Strange" },
                    { 2, "The son of Odin uses his mighty abilities as the God of Thunder to protect his home Asgard and planet Earth alike.", "Thor" },
                    { 4, "Recipient of the Super-Soldier serum, World War II hero Steve Rogers fights for American ideals as one of the world’s mightiest heroes and the leader of the Avengers.", "Captain America" },
                    { 3, "Leader of the Guardians of the Galaxy, Peter Quill, known as Star-Lord, brings a sassy sense of humor while protecting the universe from any and all threats.", "Star-Lord" },
                    { 1, "Genius. Billionaire. Playboy. Philanthropist. Tony Stark's confidence is only matched by his high-flying abilities as the hero called Iron Man.", "Iron Man" },
                    { 5, "T’Challa is the king of the secretive and highly advanced African nation of Wakanda - as well as the powerful warrior known as the Black Panther.", "Black Panter" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Image", "PlotSummary", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 12, "https://terrigen-cdn-dev.marvel.com/content/prod/1x/blackpanther_lob_crd_01_5.jpg", "Marvel Studios’ “Black Panther” follows T’Challa who, after the death of his father, the King of Wakanda, returns home to the isolated, technologically advanced African nation to succeed to the throne and take his rightful place as king. But when a powerful old enemy reappears, T’Challa’s mettle as king—and Black Panther—is tested when he is drawn into a formidable conflict that puts the fate of Wakanda and the entire world at risk. Faced with treachery and danger, the young king must rally his allies and release the full power of Black Panther to defeat his foes and secure the safety of his people and their way of life.", new DateTime(2018, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Panther" },
                    { 11, "https://terrigen-cdn-dev.marvel.com/content/prod/1x/doctorstrange_lob_crd_01_7.jpg", "From Marvel Studios comes “Doctor Strange,” the story of world-famous neurosurgeon Dr. Stephen Strange whose life changes forever after a horrific car accident robs him of the use of his hands. When traditional medicine fails him, he is forced to look for healing, and hope, in an unlikely place—a mysterious enclave known as Kamar-Taj. He quickly learns that this is not just a center for healing but also the front line of a battle against unseen dark forces bent on destroying our reality. Before long Strange—armed with newly acquired magical powers—is forced to choose whether to return to his life of fortune and status or leave it all behind to defend the world as the most powerful sorcerer in existence.", new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor Strange" },
                    { 10, "https://terrigen-cdn-dev.marvel.com/content/prod/1x/captainamericacivilwar_lob_crd_01_10.jpg", "Marvel’s “Captain America: Civil War” finds Steve Rogers leading the newly formed team of Avengers in their continued efforts to safeguard humanity. But after another incident involving the Avengers results in collateral damage, political pressure mounts to install a system of accountability, headed by a governing body to oversee and direct the team. The new status quo fractures the Avengers, resulting in two camps—one led by Steve Rogers and his desire for the Avengers to remain free to defend humanity without government interference, and the other following Tony Stark’s surprising decision to support government oversight and accountability.", new DateTime(2016, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Captain America: Civil War" },
                    { 9, "https://terrigen-cdn-dev.marvel.com/content/prod/1x/avengersageofultron_lob_crd_03_0.jpg", "Marvel Studios presents “Avengers: Age of Ultron,” the epic follow-up to the biggest Super Hero movie of all time. When Tony Stark tries to jumpstart a dormant peacekeeping program, things go awry and Earth’s Mightiest Heroes, including Iron Man, Captain America, Thor, The Incredible Hulk, Black Widow and Hawkeye, are put to the ultimate test as the fate of the planet hangs in the balance. As the villainous Ultron emerges, it is up to the Avengers to stop him from enacting his terrible plans, and soon uneasy alliances and unexpected action pave the way for an epic and unique global adventure.", new DateTime(2015, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers: Age of Ultron" },
                    { 8, "https://images-na.ssl-images-amazon.com/images/I/71O3WJv6XzL._SY606_.jpg", "In the aftermath of Marvel's 'Thor' and 'Marvel's The Avengers,' Thor fights to restore order across the cosmos...but an ancient race led by the vengeful Malekith returns to plunge the universe back into darkness. Faced with an enemy that even Odin and Asgard cannot withstand, Thor must embark on his most perilous and personal journey yet, one that will reunite him with Jane Foster and force him to sacrifice everything to save us all.", new DateTime(2013, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor: The Dark World" },
                    { 7, "https://images-na.ssl-images-amazon.com/images/I/71aYephNm9L._SY606_.jpg", "Marvel's 'Iron Man 3' pits brash-but-brilliant industrialist Tony Stark/Iron Man against an enemy whose reach knows no bounds. When Stark finds his personal world destroyed at his enemy's hands, he embarks on a harrowing quest to find those responsible. This journey, at every turn, will test his mettle. With his back against the wall, Stark is left to survive by his own devices, relying on his ingenuity and instincts to protect those closest to him. As he fights his way back, Stark discovers the answer to the question that has secretly haunted him: does the man make the suit or does the suit make the man.", new DateTime(2013, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Man 3" },
                    { 5, "https://images-na.ssl-images-amazon.com/images/I/51Xp%2B8qDCbL.jpg", "Marvel's 'Captain America: The First Avenger' focuses on the early days of the Marvel Universe when Steve Rogers volunteers to participate in an experimental program that turns him into the Super Soldier known as Captain America.", new DateTime(2011, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Captain America: The First Avenger" },
                    { 4, "https://i.pinimg.com/originals/fd/f0/af/fdf0af82063887c10cad7a3ecc6822cb.jpg", "As the son of Odin, king of the Norse gods, Thor will soon inherit the throne of Asgard from his aging father. However, on the day that he is to be crowned, Thor reacts with brutality when the gods' enemies, the Frost Giants, enter the palace in violation of their treaty. As punishment, Odin banishes Thor to Earth. While Loki, Thor's brother, plots mischief in Asgard, Thor, now stripped of his powers, faces his greatest threat.", new DateTime(2011, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor" },
                    { 3, "https://images-na.ssl-images-amazon.com/images/I/81sC6pkIARL._SY445_.jpg", "With the world now aware that he is Iron Man, billionaire inventor Tony Stark faces pressure from all sides to share his technology with the military. He is reluctant to divulge the secrets of his armored suit, fearing the information will fall into the wrong hands. With Pepper Potts and 'Rhodey' Rhodes by his side, Tony must forge new alliances and confront a powerful new enemy.", new DateTime(2010, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Man 2" },
                    { 2, "https://m.media-amazon.com/images/M/MV5BMTUyNzk3MjA1OF5BMl5BanBnXkFtZTcwMTE1Njg2MQ@@._V1_.jpg", "In this new beginning, scientist Bruce Banner desperately hunts for a cure to the gamma radiation that poisoned his cells and unleashes the unbridled force of rage within him: The Hulk. Living in the shadows--cut off from a life he knew and the woman he loves, Betty Ross--Banner struggles to avoid the obsessive pursuit of his nemesis, General Thunderbolt Ross and the military machinery that seeks to capture him and brutally exploit his power. As all three grapple with the secrets that led to the Hulk's creation, they are confronted with a monstrous new adversary known as the Abomination, whose destructive strength exceeds even the Hulk's own. One scientist must make an agonizing final choice: accept a peaceful life as Bruce Banner or find heroism in the creature he holds inside--The Incredible Hulk.", new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Incredible Hulk" },
                    { 1, "https://images-na.ssl-images-amazon.com/images/I/710bfuwiwiL._SY450_.jpg", "2008's Iron Man tells the story of Tony Stark, a billionaire industrialist and genius inventor who is kidnapped and forced to build a devastating weapon. Instead, using his intelligence and ingenuity, Tony builds a high-tech suit of armor and escapes captivity. When he uncovers a nefarious plot with global implications, he dons his powerful armor and vows to protect the world as Iron Man.", new DateTime(2008, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Man" },
                    { 13, "https://terrigen-cdn-dev.marvel.com/content/prod/1x/avengersinfinitywar_lob_crd_02.jpg", "An unprecedented cinematic journey ten years in the making and spanning the entire Marvel Cinematic Universe, Marvel Studios' 'Avengers: Infinity War' brings to the screen the ultimate, deadliest showdown of all time. As the Avengers and their allies have continued to protect the world from threats too large for any one hero to handle, a new danger has emerged from the cosmic shadows: Thanos. A despot of intergalactic infamy, his goal is to collect all six Infinity Stones, artifacts of unimaginable power, and use them to inflict his twisted will on all of reality. Everything the Avengers have fought for has led up to this moment - the fate of Earth and existence itself has never been more uncertain.", new DateTime(2018, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers: Infinity War" },
                    { 6, "https://images-na.ssl-images-amazon.com/images/I/719SFBdxRtL._SY679_.jpg", "Marvel Studios presents in association with Paramount Pictures 'Marvel's The Avengers'--the super hero team up of a lifetime, featuring iconic Marvel super heroes Iron Man, the Incredible Hulk, Thor, Captain America, Hawkeye and Black Widow. When an unexpected enemy emerges that threatens global safety and security, Nick Fury, Director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins.", new DateTime(2012, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers" }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Advantage", "Description", "HeroId", "Name" },
                values: new object[] { 11, 999.0, null, null, "Infinity Gauntlet" });

            migrationBuilder.InsertData(
                table: "HeroAbilities",
                columns: new[] { "HeroId", "AbilityId" },
                values: new object[,]
                {
                    { 1, 18 },
                    { 7, 8 },
                    { 7, 10 },
                    { 6, 14 },
                    { 6, 5 },
                    { 8, 1 },
                    { 8, 2 },
                    { 5, 10 },
                    { 5, 4 },
                    { 5, 3 },
                    { 5, 2 },
                    { 5, 1 },
                    { 8, 3 },
                    { 8, 4 },
                    { 4, 10 },
                    { 7, 1 },
                    { 4, 4 },
                    { 4, 2 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 4, 3 },
                    { 2, 3 },
                    { 2, 1 },
                    { 3, 5 },
                    { 8, 17 },
                    { 8, 16 },
                    { 4, 1 },
                    { 2, 10 },
                    { 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "SecretIdentities",
                columns: new[] { "Id", "FirstName", "HeroId", "LastName" },
                values: new object[,]
                {
                    { 7, "Peter", 8, "Parker" },
                    { 8, "Scott", 9, "Lang" },
                    { 9, "Bucky", 10, "Barnes" },
                    { 6, "Bruce", 7, "Banner" },
                    { 5, "Steven", 6, "Strange" },
                    { 4, "T'Challa", 5, null },
                    { 3, "Steve", 4, "Rogers" },
                    { 2, "Peter", 3, "Quill" },
                    { 1, "Tony", 1, "Stark" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "LeaderId", "MovieId", "Name" },
                values: new object[,]
                {
                    { 10, null, 4, 10, "Team Cap" },
                    { 9, null, 1, 10, "Team Tony" },
                    { 8, null, 1, 8, "Thor: The Dark World" },
                    { 7, null, 1, 7, "Iron Man 3" },
                    { 6, null, 1, 6, "Avengers" },
                    { 5, null, 4, 5, "Captain America: The First Avenger" },
                    { 4, null, 2, 4, "Thor" },
                    { 3, null, 1, 3, "Iron Man 2" },
                    { 2, null, 7, 2, "The Incredible Hulk" },
                    { 1, null, 1, 1, "Iron Man" }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Advantage", "Description", "HeroId", "Name" },
                values: new object[,]
                {
                    { 1, 250.0, null, 1, "Iron Man Armor" },
                    { 7, 600.0, null, 6, "Eye of Agamotto" },
                    { 9, 150.0, null, 8, "Web shooters" },
                    { 8, 10.0, null, 8, "Spidey suit" },
                    { 2, 300.0, null, 2, "Mjolnir" },
                    { 3, 150.0, null, 3, "Jet Boots" },
                    { 4, 150.0, null, 4, "Vibranium shield" },
                    { 5, 300.0, null, 5, "Vibranium armor" },
                    { 10, 250.0, null, 9, "Ant-Man Suit" },
                    { 6, 120.0, null, 6, "Cloak of levitation" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "TeamId", "MemberId" },
                values: new object[,]
                {
                    { 4, 2 },
                    { 10, 4 },
                    { 9, 8 },
                    { 9, 5 },
                    { 9, 1 },
                    { 8, 4 },
                    { 8, 1 },
                    { 7, 7 },
                    { 7, 1 },
                    { 6, 7 },
                    { 6, 4 },
                    { 6, 2 },
                    { 6, 1 },
                    { 5, 4 },
                    { 10, 9 },
                    { 10, 10 },
                    { 2, 7 },
                    { 1, 1 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "WeaponAbilities",
                columns: new[] { "WeaponId", "AbilityId" },
                values: new object[,]
                {
                    { 7, 15 },
                    { 6, 6 },
                    { 5, 13 },
                    { 3, 6 },
                    { 2, 12 },
                    { 2, 11 },
                    { 2, 6 },
                    { 1, 2 },
                    { 1, 9 },
                    { 1, 7 },
                    { 1, 6 },
                    { 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroAbilities_AbilityId",
                table: "HeroAbilities",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentities_HeroId",
                table: "SecretIdentities",
                column: "HeroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_MemberId",
                table: "TeamMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeaderId",
                table: "Teams",
                column: "LeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MovieId",
                table: "Teams",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponAbilities_AbilityId",
                table: "WeaponAbilities",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_HeroId",
                table: "Weapons",
                column: "HeroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroAbilities");

            migrationBuilder.DropTable(
                name: "SecretIdentities");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "WeaponAbilities");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
