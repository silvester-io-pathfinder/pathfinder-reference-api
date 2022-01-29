using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class IncredibleMovement : Template
    {
        public static readonly Guid ID = Guid.Parse("7c1fafad-4c33-47e5-a331-fe22ce555972");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Incredible Movement", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5a6c0059-8921-4914-9021-02f713725c9f"), Type = TextBlockType.Text, Text = "You move like the wind. You gain a +10-foot status bonus to your Speed whenever you're not wearing armor. The bonus increases by 5 feet for every 4 levels you have beyond 3rd." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse("dbff2b3d-6d96-4b60-84f2-b30101f8d644"), prerequisites => 
            {
                prerequisites.HaveCurrentArmorCategory(Guid.Parse("b0daeedd-6989-47d5-a936-43f4627803ca"), ArmorCategories.Instances.Unarmored.ID);
            });

            builder.ModifySpecificSpeed(Guid.Parse("578532c2-3fb7-4841-a711-aac48c1805df"), MovementMethod.Walking, ModifierType.Add, 10)
                .AddPrerequisites(Guid.Parse("b76999fb-2235-40a4-9ae5-bea05de691d2"), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse("b2f6b54d-0996-4022-aff6-a9adabe9961c"), Comparator.GreaterThanOrEqualTo, requiredLevel: 3); });

            builder.ModifySpecificSpeed(Guid.Parse("4dd71172-ca96-45af-b302-9a2b8d60c58b"), MovementMethod.Walking, ModifierType.Add, 5)
                .AddPrerequisites(Guid.Parse("5f5955ec-2b40-4c2d-b81c-196a64640e5c"), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse("af2353fe-9bd0-4908-8bf8-36532ab039a2"), Comparator.GreaterThanOrEqualTo, requiredLevel: 7); });

            builder.ModifySpecificSpeed(Guid.Parse("689ff967-9382-478b-a87f-d40bc8830e39"), MovementMethod.Walking, ModifierType.Add, 5)
                .AddPrerequisites(Guid.Parse("ce747400-d1ce-44eb-a8ff-1454b6b8e6df"), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse("7f7cf07d-6038-4429-9f9f-3313e264d3bf"), Comparator.GreaterThanOrEqualTo, requiredLevel: 11); });

            builder.ModifySpecificSpeed(Guid.Parse("2f8fc654-b49b-4784-a4f3-a076b70c7933"), MovementMethod.Walking, ModifierType.Add, 5)
                .AddPrerequisites(Guid.Parse("742b7c64-cd01-4da5-b530-e6cd35422b5d"), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse("5970964f-9968-4ac1-9471-4144080ebc11"), Comparator.GreaterThanOrEqualTo, requiredLevel: 15); });

            builder.ModifySpecificSpeed(Guid.Parse("e075b3a7-483b-437b-b764-737e17a69e02"), MovementMethod.Walking, ModifierType.Add, 5)
                .AddPrerequisites(Guid.Parse("bdaa3737-3217-4cb2-9957-0932d6dc579e"), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse("c8387c5e-1cb3-431e-ac84-8ce84c43fb00"), Comparator.GreaterThanOrEqualTo, requiredLevel: 19); });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a23eb9f9-51f1-4a1f-9d2e-20417fd60f1d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
