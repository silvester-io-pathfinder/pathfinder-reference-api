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
    public class KnightInShiningArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("87671181-1973-43c4-bb1c-8ef5f3ee6576");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knight in Shining Armor",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79e401d1-a779-438c-8065-cbfc35a011b6"), Type = TextBlockType.Text, Text = $"As a knight in shining armor, you train daily in the heaviest armor, expanding your expertise to heavy armor. You gain expert proficiency in heavy armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f4468e40-b5b8-40f8-aa0b-80c0c471c0e6"), Feats.Instances.KnightVigilantDedication.ID);
            builder.AddOr(Guid.Parse("1c045c71-78f2-497b-b678-628553b5bf22"), or => 
            {
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("bcdb6c74-2f40-4ec9-99e5-e2782ccd60d2"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.LightArmor.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("cb52fe13-36ed-4c6a-9546-837ccd621fa3"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.MediumArmor.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("b60feebc-ad9f-4b42-92ce-eb4e999e7f0d"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Unarmored.ID);
            });
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("3bd64c65-cced-48fa-a77e-250df87966d8"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.HeavyArmor.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43c0c2d1-fb65-4867-bba1-4ad7422cc234"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
