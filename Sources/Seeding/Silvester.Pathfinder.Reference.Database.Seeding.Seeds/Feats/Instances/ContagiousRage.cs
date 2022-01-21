using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ContagiousRage : Template
    {
        public static readonly Guid ID = Guid.Parse("fb2ba30f-8f5d-4f9f-8c8d-8c568a304d5f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Contagious Rage",
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
            yield return new TextBlock { Id = Guid.Parse("8ba7f5ec-b7ec-4a9e-b417-430e37151392"), Type = TextBlockType.Text, Text = $"You can drive your allies into a frenzy, granting them incredible benefits. You can ignore the requirements on {ToMarkdownLink<Models.Entities.Feat>("Share Rage", Feats.Instances.ShareRage.ID)}, using it multiple times in a {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)}. Allies affected by {ToMarkdownLink<Models.Entities.Feat>("Share Rage", Feats.Instances.ShareRage.ID)} who accept your anathema for the duration of the {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)} gain your instinct ability and the specialization ability it gains from weapon specialization, but not greater weapon specialization." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cb8fc856-4596-4bdc-939b-b96b71befd00"), Feats.Instances.ShareRage.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bca98fa-aaf8-4a20-8843-1964e65467f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
