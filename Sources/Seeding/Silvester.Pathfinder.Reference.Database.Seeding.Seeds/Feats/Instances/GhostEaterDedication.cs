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
    public class GhostEaterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d7fd360b-d705-448f-be09-a8951deb0b52");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ghost Eater Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from this archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3025e4b-bc75-4554-b1d6-ef1a0045016f"), Type = TextBlockType.Text, Text = $"You have trained as a ghost eater, a hunter specialized in the destruction of spirits. You know how to channel your own spiritual energy to harm spirits. Your weapon and unarmed attack {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} become magical. Against incorporeal creatures, they also gain the effects of a {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("ghost touch property rune", Items.WeaponPropertyRunes.Instances.GhostTouch.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("78fde455-ca15-490f-ad22-f4c17b4cc8b0"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("7ede3355-ebee-422d-84a7-b90dfd458f9e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("4512243c-d7de-4907-a2a4-1a6321e60f23"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5df8548-232a-4f02-9f8d-3303c314d7bf"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
