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
    public class BestiaryScholar : Template
    {
        public static readonly Guid ID = Guid.Parse("c246498c-67ed-4be9-bb07-02fb6de678d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bestiary Scholar",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bba4d064-181a-4781-9fd9-5b72d304c815"), Type = TextBlockType.Text, Text = $"You learn how to apply your extensive knowledge of certain creatures using the lore you know. When you gain this feat, choose one of the following skills in which you have attained master proficiency: Arcana, Crafting, Nature, Occultism, or Religion." };
            yield return new TextBlock { Id = Guid.Parse("f939c4ba-833c-4b9a-a83b-4866fc81b71a"), Type = TextBlockType.Text, Text = $"You can use the chosen skill to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} to identify any creature normally identifiable by any of the above skills. In addition, when you critically succeed at identifying a creature, you gain a +1 circumstance bonus to your next attack roll or saving throw against that creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("3b7db323-049b-419e-9993-cd9f53df2219"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("6a246031-a90d-4d1b-9707-4b0851998236"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("e9c80237-a8e4-4f82-a5fa-96c97811559b"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("59cfc550-d7a8-4663-8796-3eadeb1214d1"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("1f80b421-3d29-4574-82c8-3435d949615b"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("7ff3cddb-bff6-4703-995c-6c14e22d7438"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("ffc68934-4818-4e21-9ddf-6122bf37b1a6"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2ea8b469-6c1a-4dcf-8bb8-9672a05b5bf5"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0e9d14f-c8d0-4122-9e3d-9d2ceed1c316"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
