using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodFrenzy : Template
    {
        public static readonly Guid ID = Guid.Parse("9b184430-2e6a-46f7-93e2-b28709fed830");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blood Frenzy",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21555eb2-4494-4c00-b433-1c75928d430f"), Type = TextBlockType.Text, Text = $"Your eidolon flies into a frenzy. It gains the benefits of {ToMarkdownLink<Models.Entities.Spell>("boost eidolon", Spells.Instances.BoostEidolon.ID)} and gains temporary HP equal to your level, but takes a –2 penalty to AC. It can't voluntarily end the frenzy or start another frenzy while in the frenzy. The frenzy lasts for 1 minute, after which your eidolon is fatigued for 1 minute and can't start another frenzy for 1 minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2c99b82d-a72e-45b9-973a-171ec8aa9a13"), Feats.Instances.BloodlettingClaws.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d54bdc7f-66d5-4514-a930-11e773ba3bdc"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
