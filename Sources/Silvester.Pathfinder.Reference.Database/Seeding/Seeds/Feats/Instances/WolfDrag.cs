using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WolfDrag : Template
    {
        public static readonly Guid ID = Guid.Parse("d7adce1a-568a-4180-8b91-5215313afbf9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wolf Drag",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06bcca01-d87c-4aa2-9447-73507fd23cc9"), Type = TextBlockType.Text, Text = "You rip your enemy off their feet. Make a wolf jaw (action: Strike). Your wolf jaw gains the (trait: fatal d12) trait for this (action: Strike), and if the attack succeeds, you knock the target prone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fe3e6809-9872-44e9-8a48-4cbc6b5a14cb"), Feats.Instances.WolfStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d366617e-9448-4803-b22c-726f9845df08"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
