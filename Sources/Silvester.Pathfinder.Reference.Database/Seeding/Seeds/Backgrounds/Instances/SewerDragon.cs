using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class SewerDragon : Template
    {
        public static readonly Guid ID = Guid.Parse("da6a2569-3843-4164-b7b0-817282cf0b15");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Sewer Dragon",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9dec7a2d-b445-4e22-a960-9b46f3ff52ed"), Type = TextBlockType.Text, Text = "You are one of the Sewer Dragons, born in Absalom's sewers, strengthened by a life defending your territory." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new AncestryPrerequisite { Id = Guid.Parse("6609913f-2257-4510-8e71-51f08bcdfa09"), RequiredAncestryId = Ancestries.Instances.Kobold.ID };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("e77b5be8-e496-4f34-96b1-343adbda251e"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("f9cc934a-0dbd-495b-988a-8888f20986e5"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("da3974d9-f8aa-40d0-8776-7f117a1b1447"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("10d2519e-56f4-41f2-96b8-0a4b2ec2f066")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("f0a96cc2-ee62-4703-b912-a820b9b038e2"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Crafting.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("7fa127ac-d288-4362-b06b-5fa0b629fb97"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Kobold.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("bc836cac-09ac-4af4-a701-f1525f171a54"),
                FeatId = Feats.General.SnareCraftingFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e43062ff-ee79-4183-9ec3-7ba7175781ee"),
                SourceId = Sources.Instances.PathfinderSocietyQuest10.ID,
                Page = 16
            };
        }
    }
}
