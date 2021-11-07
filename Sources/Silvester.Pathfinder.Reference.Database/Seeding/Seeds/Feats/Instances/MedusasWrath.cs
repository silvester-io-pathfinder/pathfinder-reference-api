using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MedusasWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("d2379c5e-c264-40ad-a9f5-8b777c8d18de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Medusa's Wrath",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9aa7e775-457f-4ebc-add8-171471aa84be"), Type = TextBlockType.Text, Text = "You learn a monstrous ki technique that infuses your blows with the petrifying power of a medusa’s gaze. You gain the (spell: medusa’s wrath) ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("25d844d6-76c1-4e7d-8b70-ec47683b1e40"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("921a6e85-8a6b-45da-b738-28c074322e60"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
