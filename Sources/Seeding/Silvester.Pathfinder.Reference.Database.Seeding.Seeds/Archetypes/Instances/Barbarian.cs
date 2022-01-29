using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Barbarian : Template
    {
        public static readonly Guid ID = Guid.Parse("f75ae2a4-8e78-4e3d-a7e4-57453cadca58");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Barbarian",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.BarbarianDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0d3463fb-032b-4d93-900a-cf132334addb"), Type = TextBlockType.Text, Text = "There's a rage deep inside you that sometimes breaks loose, granting you some of the might of a barbarian in addition to your other abilities." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c31ac00a-56b0-4048-a0a7-2eade9c924f3"), Type = TextBlockType.Text, Text = "The barbarian archetype is a great choice for characters that emphasize Strength and melee attacks more than usual for their class, as long as they can handle Rage's spellcasting restriction. It's especially good for characters looking to add more damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9479a533-795c-45cd-b1bc-fed735814e8d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 221
            };
        }
    }
}
