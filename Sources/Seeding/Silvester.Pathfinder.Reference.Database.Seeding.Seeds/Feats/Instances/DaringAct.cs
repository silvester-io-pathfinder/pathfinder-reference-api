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
    public class DaringAct : Template
    {
        public static readonly Guid ID = Guid.Parse("826d5f1c-e5ff-452b-9dd3-46f81d220f7f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Daring Act",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db03b046-a5cd-46ae-8abc-098c133e02aa"), Type = TextBlockType.Text, Text = $"You attempt a death-defying maneuver to distract your enemies. Select one foe within reach and attempt either an Acrobatics or Athletics check against your target's Reflex DC. If you succeed, you can {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to half your Speed (or up to your full Speed if you critically succeed) without triggering reactions from the target due to your movement, and the target is flat-footed against the next melee attack you attempt against it before the end of your turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d20017f8-17aa-4ff6-bb2a-c66780c28af4"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("76f8d31d-04a2-420f-9259-14257494e1b3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("c2a810b6-a6f4-419c-8ec2-dc71130809d6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("36c5b555-da03-439e-b220-b80911f27ea2"), Feats.Instances.FirebrandBraggartDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7898e4d-5ad7-41a3-bd9a-d38d0cf9d1af"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
