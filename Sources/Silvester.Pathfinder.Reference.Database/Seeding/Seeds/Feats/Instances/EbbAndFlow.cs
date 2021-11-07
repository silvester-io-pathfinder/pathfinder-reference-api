using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EbbAndFlow : Template
    {
        public static readonly Guid ID = Guid.Parse("bbeaf494-7c69-461a-8286-791172244ee2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ebb and Flow",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddc1f4eb-e5e2-430e-9b7e-6b54f61fa123"), Type = TextBlockType.Text, Text = "You can pull forth both positive and negative energy simultaneously to harm your enemies and heal your allies. If your next action is to cast a 1-action or 2-action (spell: heal) or (spell: harm) spell, choose one creature in range that would be harmed by the spell, and choose another creature within range that would be healed by the spell. Your heal or harm targets both creatures." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b04c6371-5b6e-430d-83b4-8020b8f69de7"), Feats.Instances.VersatileFont.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a39b264d-7c5b-4eab-9f5c-6aafbe56fe69"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
