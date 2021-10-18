using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Summoner : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have a tenuous connection to an eidolon, a bodiless being that shares your life force, and with effort you can manifest the eidolon into the world." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The summoner archetype grants you an eidolon to join you in battle. It’s a particularly helpful multiclass for characters with weaker martial abilities." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Alchemist summoners can use their eidolons as lab assistants or even as the source of experiments. They are a good fit for construct or plant eidolons." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Barbarian summoners find themselves drawn to the fury of anger phantoms, the two fueled by the same inner instinct." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Bard summoners inspire their eidolons to greater heights with their bardic performances. They often team up with eidolons who pair well with their muse, such as a fey eidolon for a polymath muse or a phantom eidolon for a warrior muse." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Champion summoners get along best with divine eidolons matching the alignment associated with their cause—angel eidolons for the tenets of good, devil eidolons for a tyrant, and so on. This allows the champion and eidolon to have a unity in philosophy and purpose that other eidolon choices might lack." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Cleric summoners often find a connection to eidolons associated with their deity, such as a Sarenite cleric who chooses an angel eidolon. Clerics’ ability to heal and support allows them to keep their eidolon healthy." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Druid summoners find the life link with primal eidolons to be a religious experience. They are especially likely to bond with eidolons that match their order, such as plant eidolons for the leaf order or beast eidolons for the animal or wild order." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Fighter summoners use tactics and techniques with their eidolons to best foes. They can partner with eidolons of any kind, but they work especially well with eidolons who provide utilities that complement their fighting style." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Monk summoners often choose eidolons that are on their own path to enlightenment, to help enrich the monk’s journey. These might be divine eidolons, especially if the monk is religious or uses divine ki spells, but they also might be phantoms seeking to transcend their phantom existence to reach the afterlife." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Ranger summoners get along best with beast and plant eidolons, but they make a good team with other eidolons as well, especially when an archer ranger teams up with a melee eidolon." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Rogue summoners gain a partner in crime that can disappear when necessary, providing the eidolon with the ultimate getaway as long as no one expects it to carry back loot from a heist. Rogues work well with tricky eidolons, such as fey, and they get a lot of mileage out of sharing their skills with their eidolon. The Unfetter Eidolon feat can be especially useful if the rogue wants to establish a quick alibi far from the eidolon’s crimes." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Sorcerer summoners often choose eidolons that match closely to their bloodline, such as a psychopomp eidolon for the psychopomp bloodline. The eidolon might even be part of the story of how the sorcerer gained their bloodline." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Wizard summoners are especially appreciative of an eidolon to help them in combat, and they tend to favor arcane eidolons like dragon and construct eidolons." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 76
            };
        }
    }
}
