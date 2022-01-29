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
    public class MarshalDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("9f4aa032-9941-4bfd-a4e8-307668c67635");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Marshal Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the marshal archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fc2471d-3c80-4796-bb36-174265d6ab54"), Type = TextBlockType.Text, Text = $"You've combined your social skills and combat training to become a talented combat leader. Choose Diplomacy or Intimidation. You become trained in that skill or become an expert if you were already trained in it." };
            yield return new TextBlock { Id = Guid.Parse("aa2177d6-7bfa-438c-bddc-e63bdb83b0b2"), Type = TextBlockType.Text, Text = $"In addition, you're surrounded by a marshal's aura in a 10-foot emanation. Your aura has the {ToMarkdownLink<Models.Entities.Trait>("emotion", Traits.Instances.Emotion.ID)}, {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} traits and grants you and allies within the aura a +1 status bonus to saving throws against {ToMarkdownLink<Models.Entities.Trait>("fear", Traits.Instances.Fear.ID)} effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("d4323489-ed2a-4976-b805-4c7502ab34ad"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
            builder.AddOr(Guid.Parse("f6b72f0c-6dec-4129-b044-c5efc95eaf3c"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("f62ad97e-2115-4243-9326-629bfe5fc44e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("278ee4ea-17fb-4def-9cbc-92f1edf22221"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a950ec01-8b91-427b-9df7-fe75e5af1e04"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
