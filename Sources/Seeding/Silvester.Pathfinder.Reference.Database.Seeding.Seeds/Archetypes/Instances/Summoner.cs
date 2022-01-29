using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Summoner : Template
    {
        public static readonly Guid ID = Guid.Parse("a2c7dd55-61eb-4a46-99ca-5cd6ca9aaf52");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Summoner",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.SummonerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1adef8c9-aeb8-4c68-98c5-2ec4188c4334"), Type = TextBlockType.Text, Text = "You have a tenuous connection to an eidolon, a bodiless being that shares your life force, and with effort you can manifest the eidolon into the world." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0c43b8d1-99e7-4430-980c-446bedc1cc67"), Type = TextBlockType.Text, Text = "The summoner archetype grants you an eidolon to join you in battle. It's a particularly helpful multiclass for characters with weaker martial abilities." };
            yield return new TextBlock { Id = Guid.Parse("dddd495a-69a9-4234-ba05-51ac946f9a5c"), Type = TextBlockType.Enumeration, Text = "Alchemist summoners can use their eidolons as lab assistants or even as the source of experiments. They are a good fit for construct or plant eidolons." };
            yield return new TextBlock { Id = Guid.Parse("d0c41a6a-0afa-4670-8470-0dd97e677c82"), Type = TextBlockType.Enumeration, Text = "Barbarian summoners find themselves drawn to the fury of anger phantoms, the two fueled by the same inner instinct." };
            yield return new TextBlock { Id = Guid.Parse("9366cd49-7804-4533-bfee-2ecc15bc8db7"), Type = TextBlockType.Enumeration, Text = "Bard summoners inspire their eidolons to greater heights with their bardic performances. They often team up with eidolons who pair well with their muse, such as a fey eidolon for a polymath muse or a phantom eidolon for a warrior muse." };
            yield return new TextBlock { Id = Guid.Parse("d218ea6a-fc3b-4a1e-8205-243e6bdb4748"), Type = TextBlockType.Enumeration, Text = "Champion summoners get along best with divine eidolons matching the alignment associated with their cause - angel eidolons for the tenets of good, devil eidolons for a tyrant, and so on. This allows the champion and eidolon to have a unity in philosophy and purpose that other eidolon choices might lack." };
            yield return new TextBlock { Id = Guid.Parse("385109a1-b5d8-48c3-b2b4-91afc1fc46fc"), Type = TextBlockType.Enumeration, Text = "Cleric summoners often find a connection to eidolons associated with their deity, such as a Sarenite cleric who chooses an angel eidolon. Clerics' ability to heal and support allows them to keep their eidolon healthy." };
            yield return new TextBlock { Id = Guid.Parse("c2634207-47f4-4110-b15f-95f27ee81724"), Type = TextBlockType.Enumeration, Text = "Druid summoners find the life link with primal eidolons to be a religious experience. They are especially likely to bond with eidolons that match their order, such as plant eidolons for the leaf order or beast eidolons for the animal or wild order." };
            yield return new TextBlock { Id = Guid.Parse("661d165c-9cdb-424b-8d44-b555981216d0"), Type = TextBlockType.Enumeration, Text = "Fighter summoners use tactics and techniques with their eidolons to best foes. They can partner with eidolons of any kind, but they work especially well with eidolons who provide utilities that complement their fighting style." };
            yield return new TextBlock { Id = Guid.Parse("0145a03d-58f2-4bc8-a6cd-9e0e7b047d75"), Type = TextBlockType.Enumeration, Text = "Monk summoners often choose eidolons that are on their own path to enlightenment, to help enrich the monk's journey. These might be divine eidolons, especially if the monk is religious or uses divine ki spells, but they also might be phantoms seeking to transcend their phantom existence to reach the afterlife." };
            yield return new TextBlock { Id = Guid.Parse("9a6ba5fb-086c-44cf-a18c-daeeaf763c4d"), Type = TextBlockType.Enumeration, Text = "Ranger summoners get along best with beast and plant eidolons, but they make a good team with other eidolons as well, especially when an archer ranger teams up with a melee eidolon." };
            yield return new TextBlock { Id = Guid.Parse("b6cda3eb-0189-4197-b7b3-c4958939a34c"), Type = TextBlockType.Enumeration, Text = "Rogue summoners gain a partner in crime that can disappear when necessary, providing the eidolon with the ultimate getaway as long as no one expects it to carry back loot from a heist. Rogues work well with tricky eidolons, such as fey, and they get a lot of mileage out of sharing their skills with their eidolon. The Unfetter Eidolon feat can be especially useful if the rogue wants to establish a quick alibi far from the eidolon's crimes." };
            yield return new TextBlock { Id = Guid.Parse("731e7679-7896-4e07-9140-4921aa8f7bd5"), Type = TextBlockType.Enumeration, Text = "Sorcerer summoners often choose eidolons that match closely to their bloodline, such as a psychopomp eidolon for the psychopomp bloodline. The eidolon might even be part of the story of how the sorcerer gained their bloodline." };
            yield return new TextBlock { Id = Guid.Parse("5d54de03-9dfe-4997-8b0d-d3ae04f7fc88"), Type = TextBlockType.Enumeration, Text = "Wizard summoners are especially appreciative of an eidolon to help them in combat, and they tend to favor arcane eidolons like dragon and construct eidolons." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4329e8e5-9f9d-4366-8e67-5b7c5dd42f70"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 76
            };
        }
    }
}
