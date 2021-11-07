using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("c70b0254-ba6c-4fe6-9e78-aed1ffaa3aa8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spell Mastery",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2be1be86-94e0-4656-a93f-ff8f34108a73"), Type = TextBlockType.Text, Text = "You have mastered a handful of spells to such a degree that you can cast them even if you haven’t prepared them. Select any four spells of 9th level or lower that you have access to. Each spell you select must be of a different level. These spells are automatically prepared when you make your daily preparations and have their own spell slots. You can select a different array of spells by spending 1 week of downtime retraining your mastered spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df3deff2-8c21-4c8f-8caa-f0eb78de8d5b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
