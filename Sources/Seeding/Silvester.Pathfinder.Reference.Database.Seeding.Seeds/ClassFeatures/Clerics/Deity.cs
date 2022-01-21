using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class Deity : Template
    {
        public static readonly Guid ID = Guid.Parse("37c8a214-a7c9-4c45-b09a-1820f234fd99");

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
            yield return new TextBlock { Id = Guid.Parse("e3a379aa-28fd-4bfc-be0b-0f8b2c03ab7c"), Type = TextBlockType.Text, Text = "As a cleric, you are a mortal servitor of a deity you revere above all others. The most common deities in Pathfinder are found here, along with their alignments, areas of concern, and the benefits you get for being a cleric of that deity. Your alignment must be one allowed by your deity, as listed in their entry. Your deity grants you the trained proficiency rank in one skill and with the deity's favored weapon. If the favored weapon is uncommon, you also get access to that weapon." };
            yield return new TextBlock { Id = Guid.Parse("ef2a0749-823f-41d7-94e1-c31d64f09110"), Type = TextBlockType.Text, Text = "Your deity also adds spells to your spell list. You can prepare these just like you can any spell on the divine spell list, once you can prepare spells of their level as a cleric. Some of these spells aren't normally on the divine list, but they're divine spells if you prepare them this way." };
            yield return new TextBlock { Id = Guid.Parse("3272300f-8b12-4121-9e1a-fb080aac4c4b"), Type = TextBlockType.Heading, Text = "Anathema" };
            yield return new TextBlock { Id = Guid.Parse("ee6ddc86-4dfc-4cb9-8d0f-9854d265f877"), Type = TextBlockType.Text, Text = "Acts fundamentally opposed to your deity's alignment or ideals are anathema to your faith. Learning or casting spells, committing acts, and using items that are anathema to your deity remove you from your deity's good graces." };
            yield return new TextBlock { Id = Guid.Parse("3339d911-e2bc-44fa-95de-adad0c97720a"), Type = TextBlockType.Text, Text = "Casting spells with the evil trait is almost always anathema to good deities, and casting good spells is likewise anathema to evil deities; similarly, casting chaotic spells is anathema to lawful deities, and casting lawful spells is anathema to chaotic deities. A neutral cleric who worships a neutral deity isn't limited this way, but their alignment might change over time if they frequently cast spells or use abilities with a certain alignment. Similarly, casting spells that are anathema to the tenets or goals of your faith could interfere with your connection to your deity. For example, casting a spell to create undead would be anathema to Pharasma, the goddess of death. For borderline cases, you and your GM determine which acts are anathema." };
            yield return new TextBlock { Id = Guid.Parse("e80dbf21-6578-45ae-9a7a-ac2d78231bcf"), Type = TextBlockType.Text, Text = "If you perform enough acts that are anathema to your deity, or if your alignment changes to one not allowed by your deity, you lose the magical abilities that come from your connection to your deity. The class features that you lose are determined by the GM, but they likely include your divine font and all divine spellcasting. These abilities can be regained only if you demonstrate your repentance by conducting an atone ritual." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: //TODO: Make this a ChoiceEffect instead.
            builder.GainAnyDeity(Guid.Parse("4d83f086-bac7-403a-ae65-cd6bdaa25a49"));
            builder.GainDeityDivineSkill(Guid.Parse("037a279d-ae98-4a08-87fc-6bccb6ddccd0"));
            builder.GainDeityFavoredWeaponProficiency(Guid.Parse("ed6fe7a3-cb2a-4ddb-83f9-f4ee4302c655"), Proficiencies.Instances.Trained.ID);
            builder.GainDeitySpells(Guid.Parse("a07dc1ab-1e45-45a6-bd0a-434c8c02c7ff"));
        }


        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aeee0d23-d59b-4967-bb97-40d3da5c3492"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 118
            };
        }
    }
}
