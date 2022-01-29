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
    public class LinkedFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("b084649c-174a-46d8-b17d-877c3f56ca03");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Linked Focus",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("809ff4bf-7dcb-4679-b756-2c27466dbb68"), Type = TextBlockType.Text, Text = $"You have linked your bonded item to the well of energy that powers your school spells. When you {ToMarkdownLink<Models.Entities.Feat>("Drain your Bonded Item", Feats.Instances.DrainBondedItem.ID)} to cast a spell of your arcane school, you also regain 1 Focus Point." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("e790db6e-11d9-4a12-9e61-9fd24475d70f"), ClassFeatures.Wizards.ArcaneBond.ID);
            builder.HaveSpecificClassFeature(Guid.Parse("ef3987bd-6379-4a9a-884b-e93d0c0cdbc8"), ClassFeatures.Wizards.ArcaneSchool.ID);
            builder.HaveAnyMagicSchool(Guid.Parse("3cc55a20-bca7-40c4-9aaf-ec437db7ad06"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd809a17-11b0-4e95-8d8c-4632a49122f0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
