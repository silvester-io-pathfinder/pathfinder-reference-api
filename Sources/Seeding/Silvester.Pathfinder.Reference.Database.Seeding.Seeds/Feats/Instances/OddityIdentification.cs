using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OddityIdentification : Template
    {
        public static readonly Guid ID = Guid.Parse("e985f4b0-57e1-4949-b9fd-6f80455f6fe3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Oddity Identification",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d5a9a59-abb4-49bc-aca2-0084300e2c4e"), Type = TextBlockType.Text, Text = $"You have a sense for spells that twist minds or reveal secrets. You gain a +2 circumstance bonus to Occultism checks to {ToMarkdownLink<Models.Entities.SkillAction>("Identify Magic", SkillActions.Instances.IdentifyMagic.ID)} with the {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)}, {ToMarkdownLink<Models.Entities.Trait>("possession", Traits.Instances.Possession.ID)}, {ToMarkdownLink<Models.Entities.Trait>("prediction", Traits.Instances.Prediction.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("scrying", Traits.Instances.Scrying.ID)} traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2f8425e2-bf76-4bb0-bbba-d466e34d3098"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8826792-ddd7-4dd1-b4c8-7025484b915a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
