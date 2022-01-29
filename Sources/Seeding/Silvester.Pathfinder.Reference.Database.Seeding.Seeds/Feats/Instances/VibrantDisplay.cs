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
    public class VibrantDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("b9549395-18d6-4cf0-b61f-4f41531e6068");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vibrant Display",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once every 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cb7a3e20-864e-4222-bb1f-be51f9986940"), Type = TextBlockType.Text, Text = $"Whereas most gnomes' coloration is static or changes slowly, you can cause your hair, eye, and skin color to scintillate in brief and disorienting bursts. Once every 10 minutes, when you use the {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)} action, you can compare your Deception check result to the Perception DCs of all adjacent creatures rather than just one creature within melee reach. It's possible to get a different degree of success for each target." };
            yield return new TextBlock { Id = Guid.Parse("7808f93d-8320-4dca-aea4-06e47a8613c2"), Type = TextBlockType.Text, Text = $"These changes are imprecise and usually short-lived, so while they allow you to periodically change your appearance in unpredictable ways, they are of little use in providing camouflage or aiding a disguise." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("e27d65a7-ebcb-4912-9540-fea3b57dc0ff"), Heritages.Instances.ChameleonGnome.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f29aa9cf-f528-4679-85aa-19e33851ef53"), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02cbe5cf-fba0-4bac-8cb2-1307ca21f55e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
