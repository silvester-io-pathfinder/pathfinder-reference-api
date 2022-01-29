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
    public class ShedTail : Template
    {
        public static readonly Guid ID = Guid.Parse("76385b8b-ea44-450e-8cc9-bcfc9222cf77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shed Tail",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You become grabbed.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b266184-f799-4a86-acc1-1693ae98fe87"), Type = TextBlockType.Text, Text = $"You can shed your tail to escape. You cease being grabbed, then {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} without triggering any reactions from the creature that grabbed you. It takes 1 week for your tail to fully grow back. Until it does, you can't use your tail unarmed attack, and you take a -2 circumstance penalty on checks to {ToMarkdownLink<Models.Entities.SkillAction>("Balance", SkillActions.Instances.Balance.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7dd67f2f-24fc-4c4f-8bef-5ceed3bb1637"), Feats.Instances.TailWhip.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88393938-e020-4b5a-b410-28e8d1a85321"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
