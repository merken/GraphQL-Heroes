using System;
using System.Collections.Generic;
using System.Linq;
using HeroApp.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace HeroApp.Data.Model
{
    class HeroesData
    {
        internal Ability superStrength = new Ability { Id = 1, Name = "Super Strength", Advantage = 50 };
        internal Ability superSpeed = new Ability { Id = 2, Name = "Super Speed", Advantage = 50 };
        internal Ability superStamina = new Ability { Id = 3, Name = "Super Stamina", Advantage = 50 };
        internal Ability superAgility = new Ability { Id = 4, Name = "Super Agility", Advantage = 50 };
        internal Ability geniusIntellect = new Ability { Id = 5, Name = "Genius Intellect", Advantage = 75 };
        internal Ability flight = new Ability { Id = 6, Name = "Flight", Advantage = 15 };
        internal Ability regenerativeLifeSupport = new Ability { Id = 7, Name = "Regenerative life support", Advantage = 15 };
        internal Ability superHealing = new Ability { Id = 8, Name = "Super healing", Advantage = 15 };
        internal Ability engergyRepulsors = new Ability { Id = 9, Name = "Energy repolsors", Advantage = 15 };
        internal Ability invulerability = new Ability { Id = 10, Name = "Invulnerability", Advantage = 100 };
        internal Ability electricManipulation = new Ability { Id = 11, Name = "Electric Manipulation", Advantage = 180 };
        internal Ability weatherManipulation = new Ability { Id = 12, Name = "Weather Manipulation", Advantage = 10 };
        internal Ability vibraniumClaws = new Ability { Id = 13, Name = "Vibranium claws", Advantage = 10 };
        internal Ability magic = new Ability { Id = 14, Name = "Mastery of Magic", Advantage = 10 };
        internal Ability spaceTimeManipulation = new Ability { Id = 15, Name = "Manipulation of Space and Time", Advantage = 10 };
        internal Ability spiderSense = new Ability { Id = 16, Name = "Spider sense", Advantage = 10 };
        internal Ability clingyness = new Ability { Id = 17, Name = "Ability to cling to any surface", Advantage = 10 };
        internal Ability genius = new Ability { Id = 18, Name = "Genius", Advantage = 99 };
        internal Ability billionaire = new Ability { Id = 19, Name = "Billionaire", Advantage = 10 };
        internal Ability playboy = new Ability { Id = 20, Name = "Playboy", Advantage = 10 };
        internal Ability philanthropist = new Ability { Id = 21, Name = "Philanthropist", Advantage = 10 };

        internal List<Hero> heroes = new List<Hero>{
            new Hero{
                Id = 1,
                Name = "Iron Man",
                Description = @"Genius. Billionaire. Playboy. Philanthropist. Tony Stark's confidence is only matched by his high-flying abilities as the hero called Iron Man.",
            },
            new Hero{
                Id = 2,
                Name = "Thor",
                Description = @"The son of Odin uses his mighty abilities as the God of Thunder to protect his home Asgard and planet Earth alike.",
            },
            new Hero{
                Id = 3,
                Name = "Star-Lord",
                Description = @"Leader of the Guardians of the Galaxy, Peter Quill, known as Star-Lord, brings a sassy sense of humor while protecting the universe from any and all threats.",
            },
            new Hero{
                Id = 4,
                Name = "Captain America",
                Description = @"Recipient of the Super-Soldier serum, World War II hero Steve Rogers fights for American ideals as one of the world’s mightiest heroes and the leader of the Avengers.",
            },
            new Hero{
                Id = 5,
                Name = "Black Panter",
                Description = @"T’Challa is the king of the secretive and highly advanced African nation of Wakanda - as well as the powerful warrior known as the Black Panther.",
            },
            new Hero{
                Id = 6,
                Name = "Dr Strange",
                Description = @"Formerly a renowned surgeon, Doctor Stephen Strange now serves as the Sorcerer Supreme—Earth’s foremost protector against magical and mystical threats.",
            },
            new Hero{
                Id = 7,
                Name = "Hulk",
                Description=@"Dr. Bruce Banner lives a life caught between the soft-spoken scientist he’s always been and the uncontrollable green monster powered by his rage.",
            },
            new Hero{
                Id = 8,
                Name = "Spider-Man",
                Description=@"Bitten by a radioactive spider, Peter Parker’s arachnid abilities give him amazing powers he uses to help others, while his personal life continues to offer plenty of obstacles.",
            },
            new Hero{
                Id = 9,
                Name = "Ant-Man",
                Description=@"When ex-criminal Scott Lang turned to his illicit skills in order to save his daughter’s life, he unexpectedly became the size-shifting, insect-commanding Super Hero known as Ant-Man!",
            },
            new Hero{
                Id = 10,
                Name = "Winter Soldier",
                Description=@"James Buchanan “Bucky” Barnes enlists to fight in World War II, but eventually literally falls in battle. Unfortunately, the evil Arnim Zola recovers him and erases his memory, turning him into a highly-trained assassin called the Winter Soldier.",
            },
        };

        internal List<SecretIdentity> secretIdentities = new List<SecretIdentity>{
            new SecretIdentity{
                Id = 1,
                HeroId = 1,
                FirstName = "Tony",
                LastName = "Stark"
            },
            new SecretIdentity{
                Id = 2,
                HeroId = 3,
                FirstName = "Peter",
                LastName = "Quill"
            },
            new SecretIdentity{
                Id = 3,
                HeroId = 4,
                FirstName = "Steve",
                LastName = "Rogers"
            },
            new SecretIdentity{
                Id = 4,
                HeroId = 5,
                FirstName = "T'Challa"
            },
            new SecretIdentity{
                Id = 5,
                HeroId = 6,
                FirstName = "Steven",
                LastName = "Strange"
            },
            new SecretIdentity{
                Id = 6,
                HeroId = 7,
                FirstName = "Bruce",
                LastName = "Banner"
            },
            new SecretIdentity{
                Id = 7,
                HeroId = 8,
                FirstName = "Peter",
                LastName = "Parker"
            },
            new SecretIdentity{
                Id = 8,
                HeroId = 9,
                FirstName = "Scott",
                LastName = "Lang"
            },
            new SecretIdentity{
                Id = 9,
                HeroId = 10,
                FirstName = "Bucky",
                LastName = "Barnes"
            }
        };

        internal List<Weapon> weapons = new List<Weapon>{
            new Weapon{ Id = 1, HeroId = 1, Name = "Iron Man Armor", Advantage = 250 },
            new Weapon{ Id = 2, HeroId = 2, Name = "Mjolnir", Advantage = 300 },
            new Weapon{ Id = 3, HeroId = 3, Name = "Jet Boots", Advantage = 150 },
            new Weapon{ Id = 4, HeroId = 4, Name = "Vibranium shield", Advantage = 150 },
            new Weapon{ Id = 5, HeroId = 5, Name = "Vibranium armor", Advantage = 300 },
            new Weapon{ Id = 6, HeroId = 6, Name = "Cloak of levitation", Advantage = 120 },
            new Weapon{ Id = 7, HeroId = 6, Name = "Eye of Agamotto", Advantage = 600 },
            new Weapon{ Id = 8, HeroId = 8, Name = "Spidey suit", Advantage = 10 },
            new Weapon{ Id = 9, HeroId = 8, Name = "Web shooters", Advantage = 150 },
            new Weapon{ Id = 10, HeroId = 9, Name = "Ant-Man Suit", Advantage = 250 },
            new Weapon{ Id = 11, Name = "Infinity Gauntlet", Advantage = 999 },
        };

        internal Movie ironMan1 = new Movie
        {
            Id = 1,
            Title = @"Iron Man",
            ReleaseDate = new DateTime(2008, 5, 2),
            Image = "https://images-na.ssl-images-amazon.com/images/I/710bfuwiwiL._SY450_.jpg",
            PlotSummary = @"2008's Iron Man tells the story of Tony Stark, a billionaire industrialist and genius inventor who is kidnapped and forced to build a devastating weapon. Instead, using his intelligence and ingenuity, Tony builds a high-tech suit of armor and escapes captivity. When he uncovers a nefarious plot with global implications, he dons his powerful armor and vows to protect the world as Iron Man."
        };

        internal Movie incredibleHulk = new Movie
        {
            Id = 2,
            Title = @"The Incredible Hulk",
            ReleaseDate = new DateTime(2008, 6, 13),
            Image = "https://m.media-amazon.com/images/M/MV5BMTUyNzk3MjA1OF5BMl5BanBnXkFtZTcwMTE1Njg2MQ@@._V1_.jpg",
            PlotSummary = @"In this new beginning, scientist Bruce Banner desperately hunts for a cure to the gamma radiation that poisoned his cells and unleashes the unbridled force of rage within him: The Hulk. Living in the shadows--cut off from a life he knew and the woman he loves, Betty Ross--Banner struggles to avoid the obsessive pursuit of his nemesis, General Thunderbolt Ross and the military machinery that seeks to capture him and brutally exploit his power. As all three grapple with the secrets that led to the Hulk's creation, they are confronted with a monstrous new adversary known as the Abomination, whose destructive strength exceeds even the Hulk's own. One scientist must make an agonizing final choice: accept a peaceful life as Bruce Banner or find heroism in the creature he holds inside--The Incredible Hulk."
        };

        internal Movie ironMan2 = new Movie
        {
            Id = 3,
            Title = @"Iron Man 2",
            ReleaseDate = new DateTime(2010, 5, 7),
            Image = "https://images-na.ssl-images-amazon.com/images/I/81sC6pkIARL._SY445_.jpg",
            PlotSummary = @"With the world now aware that he is Iron Man, billionaire inventor Tony Stark faces pressure from all sides to share his technology with the military. He is reluctant to divulge the secrets of his armored suit, fearing the information will fall into the wrong hands. With Pepper Potts and 'Rhodey' Rhodes by his side, Tony must forge new alliances and confront a powerful new enemy."
        };

        internal Movie thor1 = new Movie
        {
            Id = 4,
            Title = @"Thor",
            ReleaseDate = new DateTime(2011, 5, 6),
            Image = "https://i.pinimg.com/originals/fd/f0/af/fdf0af82063887c10cad7a3ecc6822cb.jpg",
            PlotSummary = @"As the son of Odin, king of the Norse gods, Thor will soon inherit the throne of Asgard from his aging father. However, on the day that he is to be crowned, Thor reacts with brutality when the gods' enemies, the Frost Giants, enter the palace in violation of their treaty. As punishment, Odin banishes Thor to Earth. While Loki, Thor's brother, plots mischief in Asgard, Thor, now stripped of his powers, faces his greatest threat."
        };

        internal Movie captainAmerica1 = new Movie
        {
            Id = 5,
            Title = @"Captain America: The First Avenger",
            Image = "https://images-na.ssl-images-amazon.com/images/I/51Xp%2B8qDCbL.jpg",
            ReleaseDate = new DateTime(2011, 7, 22),
            PlotSummary = @"Marvel's 'Captain America: The First Avenger' focuses on the early days of the Marvel Universe when Steve Rogers volunteers to participate in an experimental program that turns him into the Super Soldier known as Captain America."
        };

        internal Movie avengers1 = new Movie
        {
            Id = 6,
            Title = @"Avengers",
            ReleaseDate = new DateTime(2012, 5, 4),
            Image = "https://images-na.ssl-images-amazon.com/images/I/719SFBdxRtL._SY679_.jpg",
            PlotSummary = @"Marvel Studios presents in association with Paramount Pictures 'Marvel's The Avengers'--the super hero team up of a lifetime, featuring iconic Marvel super heroes Iron Man, the Incredible Hulk, Thor, Captain America, Hawkeye and Black Widow. When an unexpected enemy emerges that threatens global safety and security, Nick Fury, Director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins."
        };

        internal Movie ironMan3 = new Movie
        {
            Id = 7,
            Title = @"Iron Man 3",
            ReleaseDate = new DateTime(2013, 5, 3),
            Image = "https://images-na.ssl-images-amazon.com/images/I/71aYephNm9L._SY606_.jpg",
            PlotSummary = @"Marvel's 'Iron Man 3' pits brash-but-brilliant industrialist Tony Stark/Iron Man against an enemy whose reach knows no bounds. When Stark finds his personal world destroyed at his enemy's hands, he embarks on a harrowing quest to find those responsible. This journey, at every turn, will test his mettle. With his back against the wall, Stark is left to survive by his own devices, relying on his ingenuity and instincts to protect those closest to him. As he fights his way back, Stark discovers the answer to the question that has secretly haunted him: does the man make the suit or does the suit make the man."
        };

        internal Movie thor2 = new Movie
        {
            Id = 8,
            Title = @"Thor: The Dark World",
            ReleaseDate = new DateTime(2013, 11, 8),
            Image = "https://images-na.ssl-images-amazon.com/images/I/71O3WJv6XzL._SY606_.jpg",
            PlotSummary = @"In the aftermath of Marvel's 'Thor' and 'Marvel's The Avengers,' Thor fights to restore order across the cosmos...but an ancient race led by the vengeful Malekith returns to plunge the universe back into darkness. Faced with an enemy that even Odin and Asgard cannot withstand, Thor must embark on his most perilous and personal journey yet, one that will reunite him with Jane Foster and force him to sacrifice everything to save us all."
        };

        internal Movie avengers2 = new Movie
        {
            Id = 9,
            Title = @"Avengers: Age of Ultron",
            ReleaseDate = new DateTime(2015, 5, 1),
            Image = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/avengersageofultron_lob_crd_03_0.jpg",
            PlotSummary = @"Marvel Studios presents “Avengers: Age of Ultron,” the epic follow-up to the biggest Super Hero movie of all time. When Tony Stark tries to jumpstart a dormant peacekeeping program, things go awry and Earth’s Mightiest Heroes, including Iron Man, Captain America, Thor, The Incredible Hulk, Black Widow and Hawkeye, are put to the ultimate test as the fate of the planet hangs in the balance. As the villainous Ultron emerges, it is up to the Avengers to stop him from enacting his terrible plans, and soon uneasy alliances and unexpected action pave the way for an epic and unique global adventure."
        };

        internal Movie captainAmericaCivilWar = new Movie
        {
            Id = 10,
            Title = @"Captain America: Civil War",
            ReleaseDate = new DateTime(2016, 6, 1),
            Image = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/captainamericacivilwar_lob_crd_01_10.jpg",
            PlotSummary = @"Marvel’s “Captain America: Civil War” finds Steve Rogers leading the newly formed team of Avengers in their continued efforts to safeguard humanity. But after another incident involving the Avengers results in collateral damage, political pressure mounts to install a system of accountability, headed by a governing body to oversee and direct the team. The new status quo fractures the Avengers, resulting in two camps—one led by Steve Rogers and his desire for the Avengers to remain free to defend humanity without government interference, and the other following Tony Stark’s surprising decision to support government oversight and accountability."
        };

        internal Movie drStrange = new Movie
        {
            Id = 11,
            Title = @"Doctor Strange",
            ReleaseDate = new DateTime(2016, 11, 4),
            Image = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/doctorstrange_lob_crd_01_7.jpg",
            PlotSummary = @"From Marvel Studios comes “Doctor Strange,” the story of world-famous neurosurgeon Dr. Stephen Strange whose life changes forever after a horrific car accident robs him of the use of his hands. When traditional medicine fails him, he is forced to look for healing, and hope, in an unlikely place—a mysterious enclave known as Kamar-Taj. He quickly learns that this is not just a center for healing but also the front line of a battle against unseen dark forces bent on destroying our reality. Before long Strange—armed with newly acquired magical powers—is forced to choose whether to return to his life of fortune and status or leave it all behind to defend the world as the most powerful sorcerer in existence."
        };

        internal Movie blackPanther = new Movie
        {
            Id = 12,
            Title = @"Black Panther",
            ReleaseDate = new DateTime(2018, 2, 16),
            Image = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/blackpanther_lob_crd_01_5.jpg",
            PlotSummary = @"Marvel Studios’ “Black Panther” follows T’Challa who, after the death of his father, the King of Wakanda, returns home to the isolated, technologically advanced African nation to succeed to the throne and take his rightful place as king. But when a powerful old enemy reappears, T’Challa’s mettle as king—and Black Panther—is tested when he is drawn into a formidable conflict that puts the fate of Wakanda and the entire world at risk. Faced with treachery and danger, the young king must rally his allies and release the full power of Black Panther to defeat his foes and secure the safety of his people and their way of life."
        };

        internal Movie infinityWar = new Movie
        {
            Id = 13,
            Title = @"Avengers: Infinity War",
            ReleaseDate = new DateTime(2018, 4, 27),
            Image = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/avengersinfinitywar_lob_crd_02.jpg",
            PlotSummary = @"An unprecedented cinematic journey ten years in the making and spanning the entire Marvel Cinematic Universe, Marvel Studios' 'Avengers: Infinity War' brings to the screen the ultimate, deadliest showdown of all time. As the Avengers and their allies have continued to protect the world from threats too large for any one hero to handle, a new danger has emerged from the cosmic shadows: Thanos. A despot of intergalactic infamy, his goal is to collect all six Infinity Stones, artifacts of unimaginable power, and use them to inflict his twisted will on all of reality. Everything the Avengers have fought for has led up to this moment - the fate of Earth and existence itself has never been more uncertain."
        };
    }

    public partial class HeroesDbContext
    {
        protected void SeedData(ModelBuilder modelBuilder)
        {
            var seedData = new HeroesData();

            modelBuilder.Entity<Ability>().HasData(new List<Ability>
            {
                seedData.superStrength,
                seedData.superSpeed,
                seedData.superStamina,
                seedData.superAgility,
                seedData.geniusIntellect,
                seedData.flight,
                seedData.regenerativeLifeSupport,
                seedData.superHealing,
                seedData.engergyRepulsors,
                seedData.invulerability,
                seedData.electricManipulation,
                seedData.weatherManipulation,
                seedData.vibraniumClaws,
                seedData.magic,
                seedData.spaceTimeManipulation,
                seedData.spiderSense,
                seedData.clingyness,
                seedData.genius,
                seedData.billionaire,
                seedData.playboy,
                seedData.philanthropist
            }.ToArray());

            modelBuilder.Entity<Hero>().HasData(seedData.heroes.ToArray());
            modelBuilder.Entity<SecretIdentity>().HasData(seedData.secretIdentities.ToArray());
            modelBuilder.Entity<Weapon>().HasData(seedData.weapons.ToArray());

            modelBuilder.Entity<Movie>().HasData(
                seedData.ironMan1,
                seedData.incredibleHulk,
                seedData.ironMan2,
                seedData.thor1,
                seedData.captainAmerica1,
                seedData.avengers1,
                seedData.ironMan3,
                seedData.thor2,
                seedData.avengers2,
                seedData.captainAmericaCivilWar,
                seedData.drStrange,
                seedData.blackPanther,
                seedData.infinityWar
            );

            modelBuilder.Entity<HeroAbility>().HasData(
                new HeroAbility { HeroId = 1, AbilityId = seedData.genius.Id }, //Iron Man
                new HeroAbility { HeroId = 1, AbilityId = seedData.billionaire.Id }, //Iron Man
                new HeroAbility { HeroId = 1, AbilityId = seedData.playboy.Id }, //Iron Man
                new HeroAbility { HeroId = 1, AbilityId = seedData.philanthropist.Id }, //Iron Man

                new HeroAbility { HeroId = 2, AbilityId = seedData.superStrength.Id }, //Thor
                new HeroAbility { HeroId = 2, AbilityId = seedData.superStamina.Id }, //Thor
                new HeroAbility { HeroId = 2, AbilityId = seedData.invulerability.Id }, //Thor

                new HeroAbility { HeroId = 3, AbilityId = seedData.geniusIntellect.Id }, //Star-Lord

                new HeroAbility { HeroId = 4, AbilityId = seedData.superStrength.Id }, //Captain America
                new HeroAbility { HeroId = 4, AbilityId = seedData.superSpeed.Id }, //Captain America
                new HeroAbility { HeroId = 4, AbilityId = seedData.superStamina.Id }, //Captain America
                new HeroAbility { HeroId = 4, AbilityId = seedData.superAgility.Id }, //Captain America
                new HeroAbility { HeroId = 4, AbilityId = seedData.invulerability.Id }, //Captain America

                new HeroAbility { HeroId = 5, AbilityId = seedData.superStrength.Id }, //Black Panther
                new HeroAbility { HeroId = 5, AbilityId = seedData.superSpeed.Id }, //Black Panther
                new HeroAbility { HeroId = 5, AbilityId = seedData.superStamina.Id }, //Black Panther
                new HeroAbility { HeroId = 5, AbilityId = seedData.superAgility.Id }, //Black Panther
                new HeroAbility { HeroId = 5, AbilityId = seedData.invulerability.Id }, //Black Panther

                new HeroAbility { HeroId = 6, AbilityId = seedData.geniusIntellect.Id }, //Dr Strange
                new HeroAbility { HeroId = 6, AbilityId = seedData.magic.Id }, //Dr Strange

                new HeroAbility { HeroId = 7, AbilityId = seedData.superStrength.Id }, //Hulk
                new HeroAbility { HeroId = 7, AbilityId = seedData.superStamina.Id }, //Hulk
                new HeroAbility { HeroId = 7, AbilityId = seedData.superHealing.Id }, //Hulk
                new HeroAbility { HeroId = 7, AbilityId = seedData.invulerability.Id }, //Hulk

                new HeroAbility { HeroId = 8, AbilityId = seedData.superStrength.Id }, //Spider-Man
                new HeroAbility { HeroId = 8, AbilityId = seedData.superSpeed.Id }, //Spider-Man
                new HeroAbility { HeroId = 8, AbilityId = seedData.superStamina.Id }, //Spider-Man
                new HeroAbility { HeroId = 8, AbilityId = seedData.superAgility.Id }, //Spider-Man
                new HeroAbility { HeroId = 8, AbilityId = seedData.spiderSense.Id }, //Spider-Man
                new HeroAbility { HeroId = 8, AbilityId = seedData.clingyness.Id }); //Spider-Man

            modelBuilder.Entity<WeaponAbility>().HasData(
                new WeaponAbility { WeaponId = 1, AbilityId = seedData.superStrength.Id }, //Iron Man Suit
                new WeaponAbility { WeaponId = 1, AbilityId = seedData.flight.Id }, //Iron Man Suit
                new WeaponAbility { WeaponId = 1, AbilityId = seedData.regenerativeLifeSupport.Id }, //Iron Man Suit
                new WeaponAbility { WeaponId = 1, AbilityId = seedData.engergyRepulsors.Id }, //Iron Man Suit
                new WeaponAbility { WeaponId = 1, AbilityId = seedData.superSpeed.Id }, //Iron Man Suit

                new WeaponAbility { WeaponId = 2, AbilityId = seedData.flight.Id }, //Mjolnir
                new WeaponAbility { WeaponId = 2, AbilityId = seedData.electricManipulation.Id }, //Mjolnir
                new WeaponAbility { WeaponId = 2, AbilityId = seedData.weatherManipulation.Id }, //Mjolnir

                new WeaponAbility { WeaponId = 3, AbilityId = seedData.flight.Id }, //Jet boosters

                new WeaponAbility { WeaponId = 5, AbilityId = seedData.vibraniumClaws.Id }, //Vibranium armor

                new WeaponAbility { WeaponId = 6, AbilityId = seedData.flight.Id }, //Cloak of levitation

                new WeaponAbility { WeaponId = 7, AbilityId = seedData.spaceTimeManipulation.Id }); //Cloak of Eye of agamotto

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, LeaderId = 1, MovieId = seedData.ironMan1.Id, Name = seedData.ironMan1.Title },
                new Team { Id = 2, LeaderId = 7, MovieId = seedData.incredibleHulk.Id, Name = seedData.incredibleHulk.Title },
                new Team { Id = 3, LeaderId = 1, MovieId = seedData.ironMan2.Id, Name = seedData.ironMan2.Title },
                new Team { Id = 4, LeaderId = 2, MovieId = seedData.thor1.Id, Name = seedData.thor1.Title },
                new Team { Id = 5, LeaderId = 4, MovieId = seedData.captainAmerica1.Id, Name = seedData.captainAmerica1.Title },
                new Team { Id = 6, LeaderId = 1, MovieId = seedData.avengers1.Id, Name = seedData.avengers1.Title },
                new Team { Id = 7, LeaderId = 1, MovieId = seedData.ironMan3.Id, Name = seedData.ironMan3.Title },
                new Team { Id = 8, LeaderId = 1, MovieId = seedData.thor2.Id, Name = seedData.thor2.Title },
                new Team { Id = 9, LeaderId = 1, MovieId = seedData.captainAmericaCivilWar.Id, Name = "Team Tony" },
                new Team { Id = 10, LeaderId = 4, MovieId = seedData.captainAmericaCivilWar.Id, Name = "Team Cap" });

            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { TeamId = 1, MemberId = 1 },
                new TeamMember { TeamId = 2, MemberId = 7 },
                new TeamMember { TeamId = 3, MemberId = 1 },
                new TeamMember { TeamId = 4, MemberId = 2 },
                new TeamMember { TeamId = 5, MemberId = 4 },
                new TeamMember { TeamId = 6, MemberId = 1 },
                new TeamMember { TeamId = 6, MemberId = 2 },
                new TeamMember { TeamId = 6, MemberId = 4 },
                new TeamMember { TeamId = 6, MemberId = 7 },
                new TeamMember { TeamId = 7, MemberId = 1 },
                new TeamMember { TeamId = 7, MemberId = 7 },
                new TeamMember { TeamId = 8, MemberId = 1 },
                new TeamMember { TeamId = 8, MemberId = 4 },

                new TeamMember { TeamId = 9, MemberId = 1 },
                new TeamMember { TeamId = 9, MemberId = 5 },
                new TeamMember { TeamId = 9, MemberId = 8 },

                new TeamMember { TeamId = 10, MemberId = 4 },
                new TeamMember { TeamId = 10, MemberId = 9 },
                new TeamMember { TeamId = 10, MemberId = 10 }

            );
        }
    }
}