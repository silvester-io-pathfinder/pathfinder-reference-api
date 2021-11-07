using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflectSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("680fa771-16c6-4ae6-ad4d-f8cc1cd9c638");

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
            yield return new TextBlock { Id = Guid.Parse("e8fbd15c-af6f-4f5c-a521-bb74cb3eb011"), Type = TextBlockType.Text, Text = "When you successfully use (feat: Counterspell) to counteract a spell that affects targeted creatures or an area, you can turn that spell’s effect back on its caster. When reflected, the spell affects only the original caster, even if it’s an area spell or it would normally affect more than one creature. The original caster can attempt a save and use other defenses against the reflected spell as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a280ea9f-3e7a-4c83-8eb4-b294cd24817b"), Feats.Instances.Counterspell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ceb05ae5-c13a-4a51-8e19-ff2fa130fc65"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
