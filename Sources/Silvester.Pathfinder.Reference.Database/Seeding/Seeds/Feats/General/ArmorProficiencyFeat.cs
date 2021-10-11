using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ArmorProficiencyFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("384659b6-1c1c-4612-9727-2d8406c2a328");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armor Proficiency",
                Level = 1,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time, you become trained in the next type of armor above.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96d02376-bd63-4d35-92f0-08c08ca9f2ca"), Type = TextBlockType.Text, Text = "You become trained in light armor. If you already were trained in light armor, you gain training in medium armor. If you were trained in both, you become trained in heavy armor." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new ArmorCategoryProficiencyEffect
            {
                Id = Guid.Parse("931a9468-ac95-405a-810f-9813ac5c123d"),
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                Prerequisites = new EffectPrerequisiteBinding[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse("163ece44-a390-4579-a65e-296a25227765"),
                        Prerequisite = new ArmorCategoryProficiencyPrerequisite { Id = Guid.Parse("85eb341b-a611-4423-ac11-dfbfc1cbff33"), ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID, ProficiencyId = Proficiencies.Instances.Trained.ID }
                    },
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse("818a8853-fe96-46e1-a42e-db29bf6cbc3b"),
                        Prerequisite = new ArmorCategoryProficiencyPrerequisite { Id = Guid.Parse("8c56d7b9-93cb-4de4-b570-b891bbffa1e6"), ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID, ProficiencyId = Proficiencies.Instances.Trained.ID }
                    }
                }
            };

            yield return new ArmorCategoryProficiencyEffect
            {
                Id = Guid.Parse("7d269b63-6957-4e29-9d58-ebda9e00af75"),
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                Prerequisites = new EffectPrerequisiteBinding[]
                {
                    new EffectPrerequisiteBinding
                    {
                        Id = Guid.Parse("62532bc2-8df8-4aad-a92a-ee8225bff309"),
                        Prerequisite = new ArmorCategoryProficiencyPrerequisite { Id = Guid.Parse("11372bcc-0741-48f5-b391-f7203265fd84"), ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID, ProficiencyId = Proficiencies.Instances.Trained.ID }
                    },
                }
            };

            yield return new ArmorCategoryProficiencyEffect
            {
                Id = Guid.Parse("50a29859-082e-4389-ac3b-0dd5535caa8a"),
                ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                ProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e13ef52-6a27-46d1-a5dd-8217205a1e5d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 258
            };
        }
    }
}
