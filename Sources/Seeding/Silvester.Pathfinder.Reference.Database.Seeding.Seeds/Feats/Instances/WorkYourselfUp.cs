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
    public class WorkYourselfUp : Template
    {
        public static readonly Guid ID = Guid.Parse("01cf6fbc-f03e-46a6-b8ec-6596e831247f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Work Yourself Up",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5465b31e-2d5c-40a3-9972-9431a7f7ff72"), Type = TextBlockType.Text, Text = $"You concentrate on your mental state, tapping into that raw emotional energy. Take your {ToMarkdownLink<Models.Entities.Feat>("Catharsis", Feats.Instances.Catharsis.ID)} reaction, causing the catharsis activation and entering your emotional fervor as normal. The fervor lasts only until the end of your turn. At the end of your emotional fervor, you experience the effects of your emotional fallout, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0fe9273d-0bf2-4f5b-b150-ac4286670e01"), Feats.Instances.CatharticMageDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3c4b827-8402-4a42-b5d0-d52557030d2b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
