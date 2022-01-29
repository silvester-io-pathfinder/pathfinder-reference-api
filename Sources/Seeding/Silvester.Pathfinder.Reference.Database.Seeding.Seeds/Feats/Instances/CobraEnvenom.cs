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
    public class CobraEnvenom : Template
    {
        public static readonly Guid ID = Guid.Parse("7de9566a-bcc0-422d-ab28-9b66f48dbeda");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cobra Envenom",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have this feat, the circumstance bonus to Fortitude saves and Fortitude DC granted by Cobra Stance increases from +1 to +2.",
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8d9b83f-65a0-47d8-9b00-eb7f92c6d5e5"), Type = TextBlockType.Text, Text = $"You lash out with devious intent and the power to envenom your foe. Make a cobra fang {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. Your reach with this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is 5 feet greater than normal. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, the target takes 1d4 persistent poison damage per weapon damage die." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("490f82c8-522f-4b51-a233-f923b5d9699f"), Feats.Instances.CobraStance.ID);
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("f7389c69-52d3-4be2-8cc0-c2160feac265"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Poison.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b24e977-c067-4497-8fb7-f867939599f5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
