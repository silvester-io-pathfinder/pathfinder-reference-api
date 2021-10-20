using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class Deity : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Deity", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As a cleric, you are a mortal servitor of a deity you revere above all others. The most common deities in Pathfinder are found here, along with their alignments, areas of concern, and the benefits you get for being a cleric of that deity. Your alignment must be one allowed by your deity, as listed in their entry. Your deity grants you the trained proficiency rank in one skill and with the deity's favored weapon. If the favored weapon is uncommon, you also get access to that weapon." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your deity also adds spells to your spell list. You can prepare these just like you can any spell on the divine spell list, once you can prepare spells of their level as a cleric. Some of these spells aren't normally on the divine list, but they're divine spells if you prepare them this way." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Anathema" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Acts fundamentally opposed to your deity's alignment or ideals are anathema to your faith. Learning or casting spells, committing acts, and using items that are anathema to your deity remove you from your deity's good graces." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Casting spells with the evil trait is almost always anathema to good deities, and casting good spells is likewise anathema to evil deities; similarly, casting chaotic spells is anathema to lawful deities, and casting lawful spells is anathema to chaotic deities. A neutral cleric who worships a neutral deity isn't limited this way, but their alignment might change over time if they frequently cast spells or use abilities with a certain alignment. Similarly, casting spells that are anathema to the tenets or goals of your faith could interfere with your connection to your deity. For example, casting a spell to create undead would be anathema to Pharasma, the goddess of death. For borderline cases, you and your GM determine which acts are anathema." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you perform enough acts that are anathema to your deity, or if your alignment changes to one not allowed by your deity, you lose the magical abilities that come from your connection to your deity. The class features that you lose are determined by the GM, but they likely include your divine font and all divine spellcasting. These abilities can be regained only if you demonstrate your repentance by conducting an atone ritual." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyDeityEffect { Id = Guid.Parse("") };
            yield return new GainDeityDivineSkillEffect { Id = Guid.Parse("") };
            yield return new GainDeityFavoredWeaponProficiencyEffect { Id = Guid.Parse(""), ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainDeitySpells { Id = Guid.Parse("") };
        }


        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 118
            };
        }
    }
}
