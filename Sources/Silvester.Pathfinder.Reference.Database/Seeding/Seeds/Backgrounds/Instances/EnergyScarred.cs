using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class EnergyScarred : Template
    {
        public static readonly Guid ID = Guid.Parse("eb19c5b9-bc2e-4b1a-9a9f-9cb9a10ed4c3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Energy Scarred",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f0f77697-b95e-4c0a-8659-f9829f09f8dc"), Type = TextBlockType.Text, Text = "Exposure to a significant magical event overloaded you with magical energy. Perhaps you were exposed to dangerous levels of magical energy that left you near death, or it built up over long-term exposure to a powerful source of magic." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.PervasiveMagic.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("2bf13636-1c09-4f8f-b133-3f095de57c58"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("6c30b83b-fd4a-4fde-84b6-46cc15bfef22"), StatId = Stats.Instances.Constitution.ID }
                }
            };

            yield return new TraitEffect
            {
                Id = Guid.Parse("6d681efb-6f9c-4a21-bae5-0fe550fb309e"),
                TraitId = Traits.Instances.Primal.ID
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("c421ddab-5e00-4c0b-95bf-4d69238453cb"),
                Choices = new Effect[] 
                {
                    new CombinedEffect
                    {
                        Id = Guid.Parse("ca4c67ef-cae8-4f5f-a0f9-2364f12bdd23"),
                        Entries = new Effect[]
                        {
                            new LoreEffect { Id = Guid.Parse("c4798f89-2c03-450c-8217-3aa1c09fb2aa"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Acid.ID },
                            new DamageResistanceEffect { Id = Guid.Parse("59c030ba-d548-4ef9-86d2-86ac8c80b613"), DamageTypeId = DamageTypes.Instances.Acid.ID}
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("d00c6199-8e8d-4de1-ac03-5f0791f4e17f"),
                        Entries = new Effect[]
                        {
                            new LoreEffect { Id = Guid.Parse("3556eeff-1e00-4472-a34f-57913173720f"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Cold.ID },
                            new DamageResistanceEffect { Id = Guid.Parse("1528eb81-79e4-499a-a3ef-7da2fbd2b12d"), DamageTypeId = DamageTypes.Instances.Cold.ID},
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("65679ab2-61c3-4bb3-b3f1-53078095490a"),
                        Entries = new Effect[]
                        {
                            new LoreEffect { Id = Guid.Parse("9753126a-733d-4871-a29f-68aa28d08bd6"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Electricity.ID },
                            new DamageResistanceEffect { Id = Guid.Parse("a9846daa-a2cf-4ed9-a60f-13d151de0d47"), DamageTypeId = DamageTypes.Instances.Electricity.ID},
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("b704f0a6-1e28-4a62-ba28-86d53e36583d"),
                        Entries = new Effect[]
                        {
                            new LoreEffect { Id = Guid.Parse("aba505aa-9fa5-4b29-8552-551f6f7cf35e"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Fire.ID },
                            new DamageResistanceEffect { Id = Guid.Parse("d3f09fce-bbe9-4633-ae08-76609c8c59a1"), DamageTypeId = DamageTypes.Instances.Fire.ID},
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("aa4bcf7b-e1dd-4047-ba71-f8a82b94dce6"),
                        Entries = new Effect[]
                        {
                            new LoreEffect { Id = Guid.Parse("9119072d-1cd3-4986-a18b-486419424c89"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Force.ID },
                            new DamageResistanceEffect { Id = Guid.Parse("d071abdf-a74d-4f7f-a1a1-182c7938267e"), DamageTypeId = DamageTypes.Instances.Force.ID},
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("81d2fe65-483a-4442-aea6-deb32adfb96b"),
                        Entries = new Effect[]
                        {
                            new LoreEffect { Id = Guid.Parse("7a453cbd-137d-4daf-bb58-76f4e752b109"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Negative.ID },
                            new DamageResistanceEffect { Id = Guid.Parse("7ea0a2a4-4140-4d9f-804b-bd9a2ee4e4dc"), DamageTypeId = DamageTypes.Instances.Negative.ID},
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("69b61ce5-b1a5-4b37-bf3d-cdb01449c6db"),
                        Entries = new Effect[]
                        {
                            new LoreEffect { Id = Guid.Parse("a66cb543-05ba-404e-9139-6e7c401666a5"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Positive.ID },
                            new DamageResistanceEffect { Id = Guid.Parse("b5dbccc1-ef8a-42f2-a544-4cd1373a410d"), DamageTypeId = DamageTypes.Instances.Positive.ID},
                        }
                    },

                    new CombinedEffect
                    {
                        Id = Guid.Parse("9b5bc4e2-546c-49a9-9f46-8203bcc97cbf"),
                        Entries = new Effect[]
                        {
                            new LoreEffect { Id = Guid.Parse("fab007f4-2c8a-4f56-aade-f99c13c75b32"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Sonic.ID },
                            new DamageResistanceEffect { Id = Guid.Parse("4171e75d-e66c-42a0-a502-e04809f2d9f5"), DamageTypeId = DamageTypes.Instances.Sonic.ID},
                        }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87bbd49f-bdd7-4b6b-89f7-3fcef64e05c2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 219
            };
        }
    }
}
