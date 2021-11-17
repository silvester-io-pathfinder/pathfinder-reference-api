using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class DragonscaledKobold : Template
    {
        public static readonly Guid ID = Guid.Parse("057b2cfd-543d-4af1-af44-454f79fd5c92");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Dragonscaled Kobold"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3d4cc3fd-5f7b-44f8-ad2b-21a623c9f9da"), Type = TextBlockType.Text, Text = "Your scales are especially colorful, possessing some of the same resistance a dragon possesses. You gain resistance equal to half your level (minimum 1) to the damage type associated with your draconic exemplar. Double this resistance against dragons� Breath Weapons." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("eb357281-7a5e-4143-8278-acdaddd73c21"), DamageTypes.Instances.Acid.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1, addendum: "Double this resistance against dragon's Breath weapons.")
                .AddPrerequisites(Guid.Parse("f40af4dc-ab74-453d-8053-2b07e1de396e"), prerequisites => 
                {
                    prerequisites.AddOr(Guid.Parse("df362bcb-3417-4025-8998-556c292b7fca"), or => 
                    {
                        or.HaveSpecificDraconicExemplar(Guid.Parse("5555f51f-a0bd-4fad-ac35-21678a227aa7"), DraconicExemplars.Instances.Black.ID);
                        or.HaveSpecificDraconicExemplar(Guid.Parse("1cd69fe1-1e16-4e5e-806b-2ec0662fa1f1"), DraconicExemplars.Instances.Copper.ID);
                    });
                });

            builder.GainSpecificDamageResistance(Guid.Parse("51904359-ac8b-4dc2-b3e6-72ac2aa9eefc"), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1, addendum: "Double this resistance against dragon's Breath weapons.")
                .AddPrerequisites(Guid.Parse("83e0611b-29d5-47e3-a16e-61c0bc65e9dc"), prerequisites =>
                {
                    prerequisites.AddOr(Guid.Parse("ac0d92ae-9677-421e-9e3d-827ae65f413d"), or =>
                    {
                        or.HaveSpecificDraconicExemplar(Guid.Parse("2fc3d5ee-c040-42da-946c-ee7c942d6d3d"), DraconicExemplars.Instances.Blue.ID);
                        or.HaveSpecificDraconicExemplar(Guid.Parse("ab413df8-4b1f-460e-bacb-8c6992c283e9"), DraconicExemplars.Instances.Bronze.ID);
                    });
                });

            builder.GainSpecificDamageResistance(Guid.Parse("bccfd0ee-7dc0-4f8a-bcd4-e6fbf41ec610"), DamageTypes.Instances.Poison.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1, addendum: "Double this resistance against dragon's Breath weapons.")
                .AddPrerequisites(Guid.Parse("7262db69-1f56-4289-9e6e-c8b4cc79a38a"), prerequisites =>
                {
                    prerequisites.HaveSpecificDraconicExemplar(Guid.Parse("eb89fe79-0be1-4a52-a2e7-81f97747323b"), DraconicExemplars.Instances.Green.ID);
                });

            builder.GainSpecificDamageResistance(Guid.Parse("2192df32-b724-4854-a63e-0fb488a4a942"), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1, addendum: "Double this resistance against dragon's Breath weapons.")
                .AddPrerequisites(Guid.Parse("2617c317-3fae-4668-8b0d-48f68332439c"), prerequisites =>
                {
                    prerequisites.AddOr(Guid.Parse("3adec5bc-7677-498f-be9f-747fc5aa5f21"), or =>
                    {
                        or.HaveSpecificDraconicExemplar(Guid.Parse("b6c9c2df-f260-4d58-98ed-eaba26368613"), DraconicExemplars.Instances.Red.ID);
                        or.HaveSpecificDraconicExemplar(Guid.Parse("8c49e570-e9d5-4645-98d2-f1cc10b0e4fe"), DraconicExemplars.Instances.Brass.ID);
                        or.HaveSpecificDraconicExemplar(Guid.Parse("0d6c710d-4f89-441d-a530-e375318533d1"), DraconicExemplars.Instances.Gold.ID);
                    });
                });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cae1a64-cf2b-4454-834a-178e198a2818"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 13
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kobold.ID;
        }
    }
}
