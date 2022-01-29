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
    public class DoctorsVisitation : Template
    {
        public static readonly Guid ID = Guid.Parse("61d45abd-92b8-4f03-b309-df0af5c66aeb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Doctor's Visitation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("adfa23b7-b5d8-407a-94f7-3d7bd3c53ac5"), Type = TextBlockType.Text, Text = $"You move to provide immediate care to those who need it. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, then use one of the following: {ToMarkdownLink<Models.Entities.Feat>("Battle Medicine", Feats.Instances.BattleMedicine.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Treat Poison", SkillActions.Instances.TreatPoison.ID)}. You can spend a second action to instead {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} and then {ToMarkdownLink<Models.Entities.SkillAction>("Administer First Aid", SkillActions.Instances.AdministerFirstAid.ID)} or {ToMarkdownLink<Models.Entities.Feat>("Treat a Condition", Feats.Instances.TreatCondition.ID)} (if you have it)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("17c134f1-742e-4044-b60a-17700ea98b71"), Feats.Instances.MedicDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8a8ba11-b460-4859-ad6c-058e0c8ffdb3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
