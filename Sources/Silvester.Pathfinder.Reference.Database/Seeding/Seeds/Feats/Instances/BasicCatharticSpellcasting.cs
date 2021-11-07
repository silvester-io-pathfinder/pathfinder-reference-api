using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicCatharticSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("eb8cba37-c030-43d0-9dc5-39e36cedd14a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Cathartic Spellcasting",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f95684dd-a2b6-4112-b8ab-95a7eaace67f"), Type = TextBlockType.Text, Text = "You gain a 1st-level spell slot. At 6th level, you gain a 2nd-level spell slot and you can select one spell from your repertoire as a signature spell. At 8th level, you gain a 3rd-level spell slot. Each time you gain a spell slot of a new level from this archetype, add a spell of the appropriate spell level to your repertoire, either a common spell of your chosen tradition or another spell of that tradition you have learned or discovered." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0f03fb4-c66f-46d3-890b-450f5f75a33f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
