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
    public class JalmeriHeavenseekerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("edbbdac3-5d62-4776-be89-176ee6d0a890");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Jalmeri Heavenseeker Dedication",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the Jalmeri heavenseeker archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("35fe1678-79e1-4724-8ea6-9426d6dee58a"), Type = TextBlockType.Text, Text = $"~ Access: trained by a current or former member of a House of Perfection" };
            yield return new TextBlock { Id = Guid.Parse("9d159c45-c27f-42e1-ae3a-ad28594b7c53"), Type = TextBlockType.Text, Text = $"Your skill and dedication have set you on a path to master the techniques of Jalmeray's greatest martial artists: victors of the Challenge of Sky and Heaven. You become trained in either Acrobatics or Occultism. You gain either the {ToMarkdownLink<Models.Entities.Feat>("Ki Rush", Feats.Instances.KiRush.ID)} or {ToMarkdownLink<Models.Entities.Feat>("Ki Strike", Feats.Instances.KiStrike.ID)} monk feat, which grants you a ki spell and a focus pool of 1 Focus Point that you can recover using the {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} activity as a monk does. If you already have both these feats, you can instead choose a single 1st-level monk feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("49641188-3b49-4928-af75-c2f88bfe6476"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c1a2f86-047d-4718-9267-436453ae5a74"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
