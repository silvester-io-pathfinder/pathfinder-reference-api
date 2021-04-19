using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class RaceSeeder : IEntitySeed<Race>
    {
        public IEnumerable<Race> GetSeedEntities()
        {
            yield return new Race { Id = Guid.Parse("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5"), BaseSpeed = 25, Name = "Catfolk", BaseHealth = 8, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991"), Description ="Curious and gregarious wanderers, catfolk combine features of felines and humanoids in both appearance and temperament. They enjoy learning new things, collecting new tales and trinkets, and ensuring their loved ones are safe and happy. Catfolk view themselves as chosen guardians of natural places in the world and are often recklessly brave, even in the face of overwhelming opposition."};
            yield return new Race { Id = Guid.Parse("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf"), BaseSpeed = 25, Name = "Kobold", BaseHealth = 6, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2"), Description = "Every kobold knows that their slight frame belies true, mighty draconic power. They are ingenious crafters and devoted allies within their warrens, but those who trespass into their territory find them to be inspired skirmishers, especially when they have the backing of a draconic sorcerer or true dragon overlord. However, these reptilian opportunists prove happy to cooperate with other humanoids when it’s to their benefit, combining caution and cunning to make their fortunes in the wider world."};
            yield return new Race { Id = Guid.Parse("903f97e5-6972-4ad2-9377-447b7d6758a3"), BaseSpeed = 25, Name = "Orc", BaseHealth = 10, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") , Description = "Orcs are forged in the fires of violence and conflict, often from the moment they are born. As they live lives that are frequently cut brutally short, orcs revel in testing their strength against worthy foes, whether by challenging a higher-ranking member of their community for dominance or raiding a neighboring settlement. Many orcs seek glory as soon as they can walk and carry a blade or club, taming wild beasts or hunting deadly monsters."};
            yield return new Race { Id = Guid.Parse("a8430e0c-d52e-477c-a058-bc970a2113ea"), BaseSpeed = 25, Name = "Ratfolk", BaseHealth = 6, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2"), Description = "Ysoki—as ratfolk call themselves—are a clever, adaptable, and fastidious ancestry who happily crowd their large families into the smallest of living spaces." };
            yield return new Race { Id = Guid.Parse("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce"), BaseSpeed = 25, Name = "Tengu", BaseHealth = 6, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991"), Description = "Tengus are a gregarious and resourceful people that have spread far and wide from their ancestral home in Tian Xia, collecting and combining whatever innovations and traditions they happen across with those from their own long history." };
        
            yield return new Race { Id = Guid.Parse("96a536c5-7fe0-4a25-af8b-881a2892b576"), BaseSpeed = 20, Name = "Dwarf", BaseHealth = 10, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991"), Description = "Dwarves have a well-earned reputation as a stoic and stern people, ensconced within citadels and cities carved from solid rock. While some see them as dour and humorless crafters of stone and metal, dwarves and those who have spent time among them understand their unbridled zeal for their work, caring far more about quality than quantity. To a stranger, they can seem untrusting and clannish, but to their friends and family, they are warm and caring, their halls filled with the sounds of laughter and hammers hitting anvils." };
            yield return new Race { Id = Guid.Parse("e6ac68fc-98bf-4012-97a1-9910f988a1a4"), BaseSpeed = 30, Name = "Elf", BaseHealth = 6, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991"), Description = "As an ancient people, elves have seen great change and have the perspective that can come only from watching the arc of history. After leaving the world in ancient times, they returned to a changed land, and they still struggle to reclaim their ancestral homes, most notably from terrible demons that have invaded parts of their lands. To some, the elves are objects of awe—graceful and beautiful, with immense talent and knowledge. Among themselves, however, the elves place far more importance on personal freedom than on living up to these ideals." };
            yield return new Race { Id = Guid.Parse("3404bf2c-eb1c-4cc6-b376-450a969af548"), BaseSpeed = 25, Name = "Gnome", BaseHealth = 6, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2"), Description = "Long ago, early gnome ancestors emigrated from the First World, realm of the fey. While it’s unclear why the first gnomes wandered to Golarion, this lineage manifests in modern gnomes as bizarre reasoning, eccentricity, obsessive tendencies, and what some see as naivete. These qualities are further reflected in their physical characteristics, such as spindly limbs, brightly colored hair, and childlike and extremely expressive facial features that further reflect their otherworldly origins." };
            yield return new Race { Id = Guid.Parse("519063b5-7283-4c0b-bb3a-d5d5edeba551"), BaseSpeed = 25, Name = "Goblin", BaseHealth = 6, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2"), Description = "The convoluted histories other people cling to don’t interest goblins. These small folk live in the moment, and they prefer tall tales over factual records. The wars of a few decades ago might as well be from the ancient past. Misunderstood by other people, goblins are happy how they are. Goblin virtues are about being present, creative, and honest. They strive to lead fulfilled lives, rather than worrying about how their journeys will end. To tell stories, not nitpick the facts. To be small, but dream big." };
            yield return new Race { Id = Guid.Parse("ed816fd4-9e13-43b4-b80f-30d2b5c910ff"), BaseSpeed = 25, Name = "Halfling", BaseHealth = 6, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2"), Description = "Claiming no place as their own, halflings control few settlements larger than villages. Instead, they frequently live among humans within the walls of larger cities, carving out small communities alongside taller folk. Many halflings lead perfectly fulfilling lives in the shadows of their larger neighbors, while others prefer a nomadic existence, traveling the world and taking advantage of opportunities and adventures as they come." };
            yield return new Race { Id = Guid.Parse("7fc53559-4776-482c-910c-be3bd84d2de4"), BaseSpeed = 25, Name = "Human", BaseHealth = 8, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991"), Description = "As unpredictable and varied as any of Golarion’s peoples, humans have exceptional drive and the capacity to endure and expand. Though many civilizations thrived before humanity rose to prominence, humans have built some of the greatest and the most terrible societies throughout the course of history, and today they are the most populous people in the realms around the Inner Sea." };
        }
    }

    public class RaceTraitJoiner : IEntityJoin<Race, RaceTrait>
    {
        public RaceTrait[] Join(Race race, RaceTrait[] raceTraits)
        {
            return race.Name switch
            {
                "Catfolk" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Catfolk").ToArray(),
                "Kobold" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Kobold").ToArray(),
                "Orc" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Orc").ToArray(),
                "Ratfolk" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Ratfolk").ToArray(),
                "Tengu" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Tengu").ToArray(),
                "Dwarf" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Dwarf").ToArray(),
                "Elf" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Elf").ToArray(),
                "Gnome" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Gnome").ToArray(),
                "Goblin" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Goblin").ToArray(),
                "Halfling" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Halfling").ToArray(),
                "Human" => raceTraits.Where(e => e.Name == "Humanoid").ToArray(),
                _ => Array.Empty<RaceTrait>()
            };
        }
    }

    public class RaceLanguageJoiner : IEntityJoin<Race, Language>
    {
        public Language[] Join(Race race, Language[] languages)
        {
            return race.Name switch
            {
                "Catfolk" => languages.Where(e => e.Name == "Common" || e.Name == "Amurrun").ToArray(),
                "Kobold" => languages.Where(e => e.Name == "Common" || e.Name == "Draconic").ToArray(),
                "Orc" => languages.Where(e => e.Name == "Common" || e.Name == "Orcish").ToArray(),
                "Ratfolk" => languages.Where(e => e.Name == "Common" || e.Name == "Ysoki").ToArray(),
                "Tengu" => languages.Where(e => e.Name == "Common" || e.Name == "Tengu").ToArray(),
                "Dwarf" => languages.Where(e => e.Name == "Common" || e.Name == "Dwarven").ToArray(),
                "Elf" => languages.Where(e => e.Name == "Common" || e.Name == "Elven").ToArray(),
                "Gnome" => languages.Where(e => e.Name == "Common" || e.Name == "Gnomish").ToArray(),
                "Goblin" => languages.Where(e => e.Name == "Common" || e.Name == "Goblin").ToArray(),
                "Halfling" => languages.Where(e => e.Name == "Common" || e.Name == "Halfling").ToArray(),
                "Human" => languages.Where(e => e.Name == "Common").ToArray(),
                _ => Array.Empty<Language>()
            };
        }
    }
}

