using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class DeitySeeder : IEntitySeeder<Deity>
    {
        public IEnumerable<Deity> GetSeedEntities()
        {
            yield return new Deity { Id = Guid.Parse("eda61d79-9877-483f-b660-bc282d270bb6"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("617c34ca-c11b-4c02-9f97-5ce7269f98bc"), Name = "Abadar", Description = "Abadar is worshipped as the god of cities, law, merchants, and wealth. Abadar’s cathedral-banks are found in many cities and places where order thrives or is gaining a foothold. Aristocrats, city guards, merchants, and those working in legal practice or who have the well-being of their community on their mind are common worshippers of the god of cities, along with dwarves in general. Abadaran priests living in cities often serve as judges, lawyers, and clerks, while those who live on the frontier work as roving magistrates, acting as judge, jury, and executioners in the name of order."};
            yield return new Deity { Id = Guid.Parse("3f66e9a6-fe24-4cdd-84de-91feb25e54ff"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("54f32060-3da3-4edf-b6dc-3839b8b7415d"), Name = "Asmodeus", Description = "Asmodeus is the First, the Dark Prince, the lord of darkness and law, and the ruler of the plane of Hell. If Asmodeus’s own scriptures are to believed—and they are corroborated by certain other accounts, like the angel-penned Book of the Damned—he is one of the oldest beings of the multiverse. These texts claim that in time before time, in a world not yet created, Asmodeus and his brother Ihys were among the first gods in existence. During these unnamed ages, the two gods quarreled over the fate of the souls of their creations, and Asmodeus slew his brother. Confident that Ihys’s act of granting mortals free will was folly, Asmodeus made his own convictions known: that existence is best served by absolute order and discipline. These claims contradict other popular creation myths, and both theologians and immortal agents of the gods doubt Asmodeus’s claims to varying degrees, but while there is no evidence to prove them, they are also difficult to refute." };
            yield return new Deity { Id = Guid.Parse("88e528a7-7a02-4151-a5f0-23e64e68916f"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2ad80bbd-a735-4431-9e3a-f784e053b756"), Name = "Calistria", Description = "As symbolized by the three daggers of her religious symbol, Calistria has three aspects: lust, revenge, and trickery. Silver-tongued and charming, she is a master of weaving insults into compliments and laying intricate groundwork for retribution at its finest. She is a goddess of vengeance, but it would be a mistake to assume that means she pursues justice. Calistria is fickle, shifting her loyalties and interests as her whims take her—though she never forgets a slight, and any who think she has forgiven will surely find it is only a matter of time before they are targeted by a long-term plot of revenge to lay them thoroughly low." };
            yield return new Deity { Id = Guid.Parse("ac4c804a-c975-40f5-bdd2-7dcb97e9502d"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("add12009-9c8a-4287-b02b-7e5b9459bf44"), Name = "Cayden Cailean", Description = "Once a mortal human, Cayden Cailean is now one the few deities known as the Ascended. In his mortal years, Cayden was a sellsword of no small fame, known for his boisterous manner, skill with a blade, and fearless resolve. During a particularly rowdy night of drinking, a series of escalating dares led the wandering mercenary to attempt the Test of the Starstone. He emerged from the Starstone Cathedral 3 days later, laughing, a fully realized god. Divine responsibility did little to change Cayden’s attitude from what it was in his mortal life. He continues to crave adventure, drink, and pleasurable company while abhorring bullies, tyrants, and cowards." };
            yield return new Deity { Id = Guid.Parse("6346a4c2-4bd0-42c3-bacf-2101d2fa9a48"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("add12009-9c8a-4287-b02b-7e5b9459bf44"), Name = "Desna", Description = "The night didn’t know beauty until Desna came into existence. While the other gods toiled away to create the world, she set her sights on the heavens, placing each star in the sky. After surveying her artistry, she hung the brightest star high in the north and made it her home. Her first gift to mortals was this beacon of hope, a twinkling sign in the dark sky that they could turn to when lost or unsure of themselves. Desna provides safe passage through the darkness to all, should they choose to follow." };
            yield return new Deity { Id = Guid.Parse("de85224c-6a69-482c-8a8d-dea0c4667e81"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2006ffe6-8a03-4d40-99ac-935d814140ec"), Name = "Erastil", Description = "Unlike many other good deities, Erastil does not send his followers out into the world to fight and crush evil. Eschewing crusades and other ventures that take his followers away from their homes, Erastil watches over those who devote their lives to family and community. He is primarily an agricultural deity, specifically focusing on those aspects of nature that either can be tamed or are of use to his followers. His domain encompasses the plants and animals that farmers, hunters, and ranchers deal with in their everyday lives. While he is a protective deity, Erastil steps in only when quiet, pastoral lives are threatened. He desires his followers to live their lives in peace, with no risk of being conscripted into armies, devoured by monsters, or destroyed by magic." };
            yield return new Deity { Id = Guid.Parse("21794a2c-45f8-404a-9ecb-8897571f6c15"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2ad80bbd-a735-4431-9e3a-f784e053b756"), Name = "Gorum", Description = "The clash of steel, the cry of victory, the gasping denial of death: these are the sound of prayers to Our Lord in Iron, for to follow Gorum is to fight. Gorum does not care the reason for battle—a village’s desperate stand against raiders is no less worthwhile to him than a crusader army marching against demons in the Sarkoris Scar—nor does he choose sides in such clashes. Good or evil, law or chaos, the reason for the fight is irrelevant. It is the thrill of battle that finds his favor, the crucible of struggle in which victory is there for the taking." };
            yield return new Deity { Id = Guid.Parse("196494f4-f104-45ad-8216-2c8bf68d3943"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "Gozreh", Description = "A timeless entity birthed from the first wind to stir the vast oceans, Gozreh wanders the world in the air and the seas. Sailors drop boxes of cargo as offerings to avoid a fatal storm, hoping to please the Wind and the Waves, even though they know that such pleas are far more likely to go unnoticed as they are to draw their deity’s attention. The deity’s temperament is fickle and their fury swift, hurling bolts of lightning and dragging to the crushing depths those who dare befoul the natural world. Gozreh is the sea that encapsulates the land and the wind that moves its surface, the birds that traverse the sky and the clouds that shield them." };
            yield return new Deity { Id = Guid.Parse("3d200ca3-0e4a-4a64-a8a1-0ad34870590c"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2006ffe6-8a03-4d40-99ac-935d814140ec"), Name = "Iomedae", Description = "Iomedae, the youngest among the prominent deities of the Inner Sea region, had already proven herself worthy of divinity before her ascension. Born in Cheliax, she followed the path of the sword and fought evil, eventually becoming a paladin of Aroden’s herald Arazni. She became a legend among the Shining Crusade, leading the Knights of Ozem in a series of victories over the Whispering Tyrant. Iomedae became the third known mortal to pass the Test of the Starstone when she ascended to divinity in 3832 AR. As Arazni had been slain during the Shining Crusade, Aroden elevated the newly ascended goddess to be his new herald. When Aroden himself died, Iomedae inherited most of his worshippers and became a major deity of honor and justice." };
            yield return new Deity { Id = Guid.Parse("980a89b8-bd72-4434-a744-10cdc645cee6"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "Irori", Description = "Irori exemplifies the concepts of self-perfection. His dogma states that he was a mortal who gained godhood through achieving a physical and mental state that surpassed mortal limitations. His followers seek to emulate their god’s divine state by perfecting themselves using the words of the Unbinding of Fetters, Irori’s sacred text. The illuminated pages of the tome detail numerous physical, spiritual, and mental exercises, as well as methods of learning and remembering." };
            yield return new Deity { Id = Guid.Parse("06a3a466-02b2-49d7-8c72-94c3e0fe7f50"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("25f9299a-9a7c-40bc-b8bd-58588d19381b"), Name = "Lamashtu", Description = "For those who revel in the corruption of the pure or who find themselves spurned and neglected by a world that despises their differences, Lamashtu offers respite among her grotesque brood. The Mother of Monsters readily accepts mortals into her fold and has made it her goal to twist mortal life toward her abhorrent ideals. Her intervention is widely known to inflict corruptions and terrible nightmares. Ostracized individuals who share her ideals will find this intervention a boon, while others treat similar events as horrible curses." };
            yield return new Deity { Id = Guid.Parse("ccad65f0-ec74-4072-96cc-9b11a5fa0a08"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "Nethys", Description = "To some, magic is a powerful weapon. To others, it’s a malleable tool. And to a few, it’s a source of purpose. With an understanding of spellcasting, creatures can cause fire to erupt from their hands, call otherworldly beings to aid them, bewitch the senses, and even bring the dead back to life. The ability to reshape reality to better suit one’s needs and desires is a powerful call that most only dream of being able to answer, and few are ever able to truly master such might. One such master was Nethys, who was revered as a god-king in ancient Osirion. Having sought to unlock all of the secrets and potential held within the planes and beyond, Nethys shattered his own mind from the sheer overload of knowledge to which he was exposed. Witnessing all of creation, the secrets of the universe, and the vast expanse of what has been seen and will be seen rent his mind in the same moment he elevated to the status of a god. Nethys gained unlimited power and the skill to utilize it, but at the cost of his core self and mental security. This resulted in a split soul, two sides warring within the same body. One seeks to destroy the world, to purge it through fire and ruin, and to conquer all that exists. The other attempts to protect the world, to elevate and educate, and to release it from its limits." };
            yield return new Deity { Id = Guid.Parse("b093bbc0-fa6f-4b45-8200-c7ef61c55606"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), Name = "Norgorber", Description = "Norgorber is the most mysterious of the Ascended, the group of mortals who assumed godhood after passing the Test of the Starstone. Unlike Iomedae’s and Cayden Cailean’s mortal existences, Norgorber’s life before his ascension is a mystery; the god himself has shrouded details of his mortal life in secrecy. This is no surprise to those familiar with Norgorber—he is the master of all secrets, a calculating manipulator who cleverly and ruthlessly wields the power of hidden knowledge to achieve his own ends. Only his most trusted worshippers know enough about his goals to assist in the god’s plans, and even those worshippers often have their memories modified after their parts in Norgorber’s schemes are complete." };
            yield return new Deity { Id = Guid.Parse("01777837-1255-4d6a-9301-96dc48fffee4"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a"), Name = "Pharasma", Description = "No record of history, and not even other gods, can recall a time before Pharasma. Her throne lies within a vast, gothic cathedral located on the infinite Spire at the center of the planes. From here, she looks both forward and backward in time, observing the births, lives, and deaths of every soul, as she serves as the final arbiter of a soul’s destination after death. Psychopomp servants of Pharasma guide and safeguard newly dead souls along the River of Souls to her realm, where she judges each soul and ensures it is sent to the proper plane for its afterlife, according to its alignment and mortal deeds. Although she can see all possible fates and knows the fate of each individual, free will and choice can alter a soul’s final destination, and she places great weight on the individual’s actions and personal choices. Therefore, Pharasma withholds her final judgment until a soul stands before her. Her prophecies are cryptic, and their full meanings are rarely revealed until the foretold events occur." };
            yield return new Deity { Id = Guid.Parse("de5a9748-6c00-49ad-966e-bcb52fcbc69b"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("25f9299a-9a7c-40bc-b8bd-58588d19381b"), Name = "Rovagug", Description = "Rovagug has no single holy scripture. He has little use for one, for his sole commandment is to destroy, and his followers need no instruction in how to accomplish that. The figurative and literal monsters who worship Rovagug share their myths and legends in secret shrines and hidden caves, calling him the Rough Beast, the Imprisoned King, the Tide of Fangs, the Unmaker, and the Worldbreaker. They tell each other that each life they snuff out, each piece of art they destroy, each work of labor they bring tumbling down puts a crack in the prison that holds their god. Each of their little efforts of destruction adds up and will one day free him, setting him loose to bring about the end of all things." };
            yield return new Deity { Id = Guid.Parse("c624bf0e-d22c-4e01-8691-041083462102"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), Name = "Sarenrae", Description = "Sarenrae is one of the most popular deities on Golarion by virtue of her association with the life-giving sun and her perpetual offer to help anyone be their best, even when they have made mistakes. Most people thank her for her kind work to channel the sun’s power for everyone’s safety and livelihood, and thank her clergy for granting her healing power to all who need it. Mortals look to the Dawnflower as an example of boundless love, exquisite kindness, and true patience. They pray to her to heal the sick, lift up the downtrodden, and illuminate darkness of circumstance as well as darkness of spirit. Her followers aspire to emulate her through generosity, nurturing, truthfulness, and selfless courage. They oppose evil everywhere with words first, and when necessary, with scimitar and flame." };
            yield return new Deity { Id = Guid.Parse("f5f38a92-1302-4d45-adf8-38452dde188b"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("e45c48a5-db00-4056-8ef3-7bd3662cfd9f"), Name = "Shelyn", Description = "Shelyn watches over existence with a kind and loving eye, encouraging mortals to make the best of their lives by spreading love, art, and beauty as best they can. Even the crudest artistic awakenings are worthy of praise in the goddess’s eyes, as they represent an individual’s expression of life’s trials and triumphs. She believes every creature is worthy of love and capable of creating art in their own way. Shelyn’s religion does not require chastity, fidelity, or a particular relationship structure, as the passion of early romance is a facet of love just as important and valid as the comfortable trust between a long-married couple. However, she does make the distinction between courtship and pure carnal desire, and she prefers that trysts blossom into more meaningful relationships along the way." };
            yield return new Deity { Id = Guid.Parse("7e6e2e04-4cb7-4ac0-83b0-06929f0102b0"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("2006ffe6-8a03-4d40-99ac-935d814140ec"), Name = "Torag", Description = "The head of the dwarven pantheon is the most visible of the dwarven deities, to the extent that Torag is the only dwarven deity most non-dwarves know of. While the other dwarven gods represent specific areas of dwarven life and culture, thus forming an expansive and comprehensive dwarven pantheon, Torag’s areas of concern are those most central to dwarven society. In his own family, Torag models the values of community and protection that have cemented deep-rooted relationships among dwarven clans. His focus on strategy and tactical acumen centers on protection, reflected in dwarves’ impenetrable fortresses and conservative military tactics, including their willingness to use offensive maneuvers as a form of defense. He also represents the forge: the creation of fine works from raw materials, practice and mastery of a craft, and pride in one’s work. His purview extends even to those activities that feed the forge and dwarven artisanship, such as mining the earth for raw ore and gemstones. Torag’s oversight over these core concepts has secured his place at the head of the dwarven pantheon for ages. It was Torag who sent the dwarves on their legendary Quest for Sky during the Age of Darkness, and his worship was long-established even then. Indeed, among dwarves, Torag is often called the Father of Creation." };
            yield return new Deity { Id = Guid.Parse("ca7cdddd-52b2-4352-9c72-230ecc190bcc"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("3a4f993d-9f0c-4615-b18a-39feb5b25a11"), Name = "Urgathoa", Description = "The chosen of Urgathoa do not dread the flaws of mortal flesh, such as aging, disease, or even death, for so long as they indulge in excess above all else, their goddess offers eternal freedom from such fickle constraints. Urgathoa herself was once a mortal woman who challenged and rejected the tenets of deities whose followers expected mindless conformity, temperance, and restraint. Why would the gods craft Golarion into a near-endless buffet abundant with pleasures of the body and mind if the living weren’t destined to feast from it? Urgathoa so loved satiating her life’s appetites that in death, she spat in the face of Pharasma’s judgment, murdered the psychopomp assigned to aid her transition to the afterlife, and tore herself from the Boneyard with a feat of will that not only returned her to the Material Plane but also transformed her into the first divine undead creature." };
            yield return new Deity { Id = Guid.Parse("4fec4b99-9934-4872-993a-aec20fcf47e1"), CategoryId = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), AlignmentId = Guid.Parse("54f32060-3da3-4edf-b6dc-3839b8b7415d"), Name = "Zon-Kuthon", Description = "The Midnight Lord embodies and glorifies pain, shadows, and mutilation, and he is one of the most twisted and malevolent gods on the face of Golarion. Once known as Dou-Bral, he crafted the immense Star Towers that still help keep Rovagug pinned in his prison at Golarion’s heart, lending his own skill and ability to the great deific alliance to bind that evil entity. Yet a divine argument between him and his sister Shelyn resulted in the god departing for parts unknown. Zon-Kuthon traveled beyond the edges of the multiverse and stared into the face of the incomprehensible things that dwell there. No one knows what he found in that place, but he returned—changed, but claiming to be strengthened by what he had endured. Likewise, the nation of Nidal on Golarion, which is bound to him, is a nation of survivors, founded by those few strong enough to do what they must so their people could survive the terrible aftermath of Earthfall and the Age of Darkness that followed." };
        }
    }

    public class DeityFollowerAlignmentJoiner : IEntityJoiner<Deity, Alignment, DeityFollowerAlignment>
    {
        public DeityFollowerAlignment[] Join(Deity deity, Alignment[] alignments)
        {
            return deity.Name switch
            {
                "Abadar" => Filter(deity, alignments, "Lawful Good", "Lawful Neutral" , "Lawful Evil"),
                "Asmodeus" => Filter(deity, alignments, "Lawful Evil"),
                "Calistria" => Filter(deity, alignments, "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"),
                "Cayden Cailean" => Filter(deity, alignments, "Neutral Good", "Chaotic Good", "Chaotic Neutral"),
                "Desna" => Filter(deity, alignments, "Neutral Good", "Chaotic Good", "Chaotic Neutral"),
                "Erastil" => Filter(deity, alignments, "Lawful Good", "Neutral Good", "Lawful Neutral"),
                "Gorum" => Filter(deity, alignments, "Chaotic Neutral", "Chaotic Evil"),
                "Gozreh" => Filter(deity, alignments, "Neutral Good", "Lawful Neutral", "True Neutral", "Chaotic Neutral", "Neutral Evil"),
                "Iomedae" => Filter(deity, alignments, "Lawful Good", "Neutral Good"),
                "Irori" => Filter(deity, alignments, "Lawful Good", "Lawful Neutral", "Lawful Evil"),
                "Lamashtu" => Filter(deity, alignments, "Chaotic Evil"),
                "Nethys" => Filter(deity, alignments, "Neutral Good", "Lawful Neutral", "True Neutral", "Chaotic Neutral", "Neutral Evil"),
                "Norgorber" => Filter(deity, alignments, "True Neutral", "Lawful Evil", "Neutral Evil", "Chaotic Evil"),
                "Pharasma" => Filter(deity, alignments, "Neutral Good", "Lawful Neutral", "True Neutral"),
                "Rovagug" => Filter(deity, alignments, "Neutral Evil", "Chaotic Evil"),
                "Sarenrae" => Filter(deity, alignments, "Lawful Good", "Neutral Good", "Chaotic Good"),
                "Shelyn" => Filter(deity, alignments, "Lawful Good", "Neutral Good", "Chaotic Good"),
                "Torag" => Filter(deity, alignments, "Lawful Good", "Lawful Neutral"),
                "Urgathoa" => Filter(deity, alignments, "Lawful Evil", "Neutral Evil", "Chaotic Evil"),
                "Zon-Kuthon" => Filter(deity, alignments, "Lawful Neutral", "Lawful Evil", "Neutral Evil"),
                _ => Array.Empty<DeityFollowerAlignment>()
            };
        }

        private static Guid InitialGuid = Guid.Parse("2052eb18-4c69-45ae-aa91-b9b027a02814");

        private static DeityFollowerAlignment[] Filter(Deity deity, Alignment[] alignments, params string[] alignmentNames)
        {
            DeityFollowerAlignment[] matches = alignments
                .Where(alignment => alignmentNames.Contains(alignment.Name))
                .Select(alignment => CreateJoin(deity, alignment))
                .ToArray();

            return matches.Length == alignmentNames.Length
                ? matches
                : throw new InvalidOperationException($"Not all alignment names could be found: {string.Join(", ", matches.Select(e => e.Alignment.Name).GetMissing(alignmentNames))}.");
        }

        private static DeityFollowerAlignment CreateJoin(Deity deity, Alignment alignment)
        {
            InitialGuid = InitialGuid.Increment();
            return new DeityFollowerAlignment { Id = InitialGuid, AlignmentId = alignment.Id, DeityId = deity.Id };
        }
    }

    public class DeityDivineFontJoiner : IEntityJoiner<Deity, DivineFont>
    {
        public DivineFont[] Join(Deity deity, DivineFont[] fonts)
        {
            return deity.Name switch
            {
                "Abadar" => Filter(fonts, "Harm", "Heal"),
                "Asmodeus" => Filter(fonts, "Harm"),
                "Calistria" => Filter(fonts, "Harm", "Heal"),
                "Cayden Cailean" => Filter(fonts, "Heal"),
                "Desna" => Filter(fonts, "Heal"),
                "Erastil" => Filter(fonts, "Heal"),
                "Gorum" => Filter(fonts, "Harm", "Heal"),
                "Gozreh" => Filter(fonts, "Heal"),
                "Iomedae" => Filter(fonts, "Heal"),
                "Irori" => Filter(fonts, "Harm", "Heal"),
                "Lamashtu" => Filter(fonts, "Harm", "Heal"),
                "Nethys" => Filter(fonts, "Harm", "Heal"),
                "Norgorber" => Filter(fonts, "Harm"),
                "Pharasma" => Filter(fonts, "Heal"),
                "Rovagug" => Filter(fonts, "Harm"),
                "Sarenrae" => Filter(fonts, "Heal"),
                "Shelyn" => Filter(fonts, "Heal"),
                "Torag" => Filter(fonts, "Heal"),
                "Urgathoa" => Filter(fonts, "Harm"),
                "Zon-Kuthon" => Filter(fonts, "Harm"),
                _ => Array.Empty<DivineFont>()
            };
        }

        private static DivineFont[] Filter(DivineFont[] fonts, params string[] fontNames)
        {
            DivineFont[] matches = fonts
                .Where(domain => fontNames.Contains(domain.Name))
                .ToArray();

            return matches.Length == fontNames.Length
                ? matches
                : throw new InvalidOperationException($"Not all font names could be found: {string.Join(", ", matches.Select(e => e.Name).GetMissing(fontNames))}.");
        }
    }

    public class DeityDomainJoiner : IEntityJoiner<Deity, Domain>
    {
        public Domain[] Join(Deity deity, Domain[] fonts)
        {
            return deity.Name switch
            {
                "Abadar" => Filter(fonts, "Cities", "Duty","Earth", "Travel", "Wealth"),
                "Asmodeus" => Filter(fonts, "Confidence", "Duty", "Fire", "Glyph", "Trickery", "Tyranny"),
                "Calistria" => Filter(fonts, "Pain", "Passion", "Secrecy", "Trickery"),
                "Cayden Cailean" => Filter(fonts, "Cities", "Freedom", "Indulgence", "Might"),
                "Desna" => Filter(fonts, "Dreams", "Luck", "Moon", "Star", "Travel", "Void"),
                "Erastil" => Filter(fonts, "Duty", "Earth", "Family", "Nature", "Wealth"),
                "Gorum" => Filter(fonts, "Confidence", "Destruction", "Might", "Zeal"),
                "Gozreh" => Filter(fonts, "Air", "Cold", "Lightning", "Nature", "Travel", "Water"),
                "Iomedae" => Filter(fonts, "Confidence", "Duty", "Might", "Truth", "Zeal"),
                "Irori" => Filter(fonts, "Change", "Knowledge", "Might", "Perfection", "Truth", "Vigil"),
                "Lamashtu" => Filter(fonts, "Change", "Family", "Might", "Nightmares", "Trickery"),
                "Nethys" => Filter(fonts, "Destruction", "Glyph", "Knowledge", "Magic", "Protection"),
                "Norgorber" => Filter(fonts, "Death", "Secrecy", "Trickery", "Wealth"),
                "Pharasma" => Filter(fonts, "Death", "Fate", "Healing", "Knowledge", "Soul", "Time", "Vigil"),
                "Rovagug" => Filter(fonts, "Air", "Destruction", "Earth", "Swarm", "Void", "Zeal"),
                "Sarenrae" => Filter(fonts, "Fire", "Healing", "Repose", "Sun", "Truth"),
                "Shelyn" => Filter(fonts, "Creation", "Family", "Passion", "Protection", "Repose" ),
                "Torag" => Filter(fonts, "Creation", "Duty", "Earth", "Family", "Protection"),
                "Urgathoa" => Filter(fonts, "Decay", "Indulgence", "Magic", "Might", "Swarm", "Undeath"),
                "Zon-Kuthon" => Filter(fonts, "Ambition", "Darkness", "Destruction", "Pain", "Void"),
                _ => Array.Empty<Domain>()
            };
        }

        private static Domain[] Filter(Domain[] domains, params string[] domainNames)
        {
            Domain[] matches = domains
                .Where(domain => domainNames.Contains(domain.Name))
                .ToArray();

            return matches.Length == domainNames.Length
                ? matches
                : throw new InvalidOperationException($"Not all domain names could be found: {string.Join(", ", matches.Select(e => e.Name).GetMissing(domainNames))}");
        }
    }
}
