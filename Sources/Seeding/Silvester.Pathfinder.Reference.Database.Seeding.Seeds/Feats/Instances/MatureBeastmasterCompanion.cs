using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MatureBeastmasterCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("ff1dca31-518a-4a70-851d-ed83320db831");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mature Beastmaster Companion",
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
            yield return new TextBlock { Id = Guid.Parse("90c8a26b-719e-4963-8393-8933c1b9b72e"), Type = TextBlockType.Text, Text = $"All of your animal companions grow up, becoming mature animal companions and gaining additional capabilities (page 214). During an encounter, even if you don't use the {ToMarkdownLink<Models.Entities.SkillAction>("Command an Animal", SkillActions.Instances.CommandAnAnimal.ID)} action, your animal companion can still use 1 action on your turn to either {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} or {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5add932d-6382-4c46-8e57-62030c23760e"), Feats.Instances.BeastmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e87e1e7-0874-4b21-a4cf-3f8326ada51b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
