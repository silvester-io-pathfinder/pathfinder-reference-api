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
    public class BrightLionDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("8dbeecb0-0efc-4d7a-87f6-6d4b22e14045");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bright Lion Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the Bright Lion archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("390765ca-9e25-4db2-9463-83cf7f6ba24e"), Type = TextBlockType.Text, Text = $"~ Access: Bright Lion background" };
            yield return new TextBlock { Id = Guid.Parse("9deaa7c9-eafa-466c-af43-3f6fa2cb07b5"), Type = TextBlockType.Text, Text = $"You become trained in your choice of Deception or Diplomacy and in Mzali Lore; if you were already trained, you become an expert instead. You incorporate enough worship of Walkena in your daily life to avoid suspicion. You typically don't need to {ToMarkdownLink<Models.Entities.SkillAction>("Lie", SkillActions.Instances.Lie.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)} to pass yourself off as a worshipper of Walkena. Against careful inspection, you gain a +4 circumstance bonus to Deception checks specifically to pass yourself off as a version of yourself faithful to Walkena." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("1b05f945-ca8e-4d46-b176-f935b9d4b21c"), "Member of the Bright Lions.");
            builder.WorshipSpecificDeity(Guid.Parse("7ddcd9d6-9e42-48ba-acdc-1ca912691c76"), Deities.Instances.Walkena.ID, isNegated: true);
            builder.HaveSpecificSkillProficiency(Guid.Parse("9167359a-7a95-40ae-91c9-f9818a2de146"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("49ce028e-cf41-4854-90bb-87d3988c9733"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("06dcd48b-7e42-4f6b-9dfb-099c58e52f2c"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a170f840-6c4c-47a5-ac9c-b85b938a15d9"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
