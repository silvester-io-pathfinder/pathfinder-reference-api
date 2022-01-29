using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DaringFlourish : Template
    {
        public static readonly Guid ID = Guid.Parse("e95100c1-01f8-46b4-8dfa-16f00f033b0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Daring Flourish",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5473ac77-7e6a-4af0-86c4-a9bc13e2fcfe"), Type = TextBlockType.Text, Text = $"You make quick use of an opening from your daring stunts. At the end of a successful {ToMarkdownLink<Models.Entities.Feat>("Daring Act", Feats.Instances.DaringAct.ID)}, you can make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the target or attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)} the target. The target is flat-footed against the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} you make during {ToMarkdownLink<Models.Entities.Feat>("Daring Act", Feats.Instances.DaringAct.ID)} as well as the next melee attack you attempt against it before the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("29ba728c-fa2f-440b-9546-128891ca2ad2"), Feats.Instances.DaringAct.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aeed6300-f415-4d54-80b3-a691d5df93f8"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
