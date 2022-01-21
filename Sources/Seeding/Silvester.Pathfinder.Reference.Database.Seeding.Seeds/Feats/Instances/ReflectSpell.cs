using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflectSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("7a3e3190-355a-45eb-baf7-fe5cbb58de7a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reflect Spell",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59ae7588-d40f-4220-b1bd-c8d7650a1a03"), Type = TextBlockType.Text, Text = "When you successfully use (feat: Counterspell) to counteract a spell that affects targeted creatures or an area, you can turn that spell's effect back on its caster. When reflected, the spell affects only the original caster, even if it's an area spell or it would normally affect more than one creature. The original caster can attempt a save and use other defenses against the reflected spell as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("08222454-a0e1-4029-8a7d-2ecd9c66fe7f"), Feats.Instances.Counterspell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d60b80cd-d56c-4ebd-ac42-5a1e36091c2a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
