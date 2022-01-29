using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Monk : Template
    {
        public static readonly Guid ID = Guid.Parse("d76ef35e-7e38-45b8-8270-b3b1e758b5ce");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Monk",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.MonkDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dfdc3366-e8d4-4b4f-b823-676a948d0044"), Type = TextBlockType.Text, Text = "Monastic training has taught you martial arts and allowed you to hone your mind, body, and spirit to new heights." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("31d9f968-84f7-4be8-83b9-56461a9ccd8c"), Type = TextBlockType.Text, Text = "The monk archetype is a strong choice for any character that fights unarmored or with unarmed attacks." };
            yield return new TextBlock { Id = Guid.Parse("daac68fc-5405-4ff3-ab2c-42ebf03cdd11"), Type = TextBlockType.Enumeration, Text = "Barbarian monks with the animal instinct can combine the barbarian's excellent unarmed damage with the monk's diverse unarmed special abilities." };
            yield return new TextBlock { Id = Guid.Parse("7ba1725a-87be-4bc8-b46e-262879518be7"), Type = TextBlockType.Enumeration, Text = "Champion monks are perfect for champions of Irori or other deities who favor unarmed attacks." };
            yield return new TextBlock { Id = Guid.Parse("19c809fe-62ce-4b9f-915a-cba11ecee259"), Type = TextBlockType.Enumeration, Text = "Fighter monks can supplement free-hand fighting and add mobility to the fighter's toolkit." };
            yield return new TextBlock { Id = Guid.Parse("82947514-3aef-4427-aad4-c169da3c2905"), Type = TextBlockType.Enumeration, Text = "Rogue monks are incredibly effective because stances grant some of the best agile finesse attacks and flurry gives more sneak attacks." };
            yield return new TextBlock { Id = Guid.Parse("8aa3f2d9-22b6-4e9f-a840-1c05a2e3436d"), Type = TextBlockType.Enumeration, Text = "Spellcaster monks can fight with a free hand and still use material components to cast spells." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae0713ca-a2ea-46a3-b136-b957b1e6a5df"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 227
            };
        }
    }
}
