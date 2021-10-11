using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Tinker : Template
    {
        public static readonly Guid ID = Guid.Parse("72dbc5dc-2f7b-45ed-bbc5-23c81d0316fa");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Tinker",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b66cc7b6-06e5-44f4-8944-b75b88ba40fb"), Type = TextBlockType.Text, Text = "Creating all sorts of minor inventions scratches your itch for problem-solving. Your engineering skills take a particularly creative bent, and no one know what you'll come up with next. It might be a genius device with tremendous potential... or it might explode." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("025d7adb-36c0-4021-97fc-a109db35cedd"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("0d947acb-427f-4927-bb2e-23c6bc3a30b4"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("c5f3271c-52c6-495c-93ae-7c847eea2230"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("ab210a72-ed31-4816-9f7a-746d70184bb3")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("d12cdb6a-519b-43b8-9962-4dec67c82045"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Crafting.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("6b46a4ef-8b3b-4646-a573-c12c0529ba9a"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Engineering.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("1a844147-1ac5-467b-9ba4-5c6338a67fb0"),
                FeatId = Feats.General.SpecialtyCraftingFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59cf5927-a48f-4459-b08a-4bd9f9ae84ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 64
            };
        }
    }
}
