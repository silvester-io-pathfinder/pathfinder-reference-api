using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GleanContents : Template
    {
        public static readonly Guid ID = Guid.Parse("f9161cb7-09da-4950-b940-7999e2d7fa5a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glean Contents",
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
            yield return new TextBlock { Id = Guid.Parse("beb8fc43-8fb6-414c-8d5d-07f3b637113c"), Type = TextBlockType.Text, Text = $"You are adept at quickly scanning loose papers and carefully discerning the contents of sealed letters without damaging the seal. You can attempt Society checks to {ToMarkdownLink<Models.Entities.SkillAction>("Decipher Writing", SkillActions.Instances.DecipherWriting.ID)} (Society) on a message that is only partially glimpsed, upside down or reversed from your perspective, or even sealed. However, on a critical failure, the recipient is made aware of your efforts (for instance, you damage the seal or disturb the papers in some way). When using this feat to decipher sealed letters, your attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Decipher Writing", SkillActions.Instances.DecipherWriting.ID)} gains the {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} trait. This feat doesn't prevent witnesses from noticing your efforts, particularly with sealed letters which you must manipulate directly in order to read; you might need to attempt Deception or Stealth checks to avoid being noticed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f3b273d6-cc57-4b5d-b9d8-0bf0607e7218"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7a4fad1-eaaa-4ece-95e9-dcd95bec8d17"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
