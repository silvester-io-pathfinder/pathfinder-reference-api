using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rackets.Instances
{
    public class EldritchTrickster : Template
    {
        public static readonly Guid ID = Guid.Parse("df414bcc-fb7a-48a4-be7d-ae8bb32bbfe1");
        
        protected override Racket GetRacket()
        {
            return new Racket
            {
                Id = ID, 
                Name = "Eldritch Trickster",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("af30e987-5be7-43bd-beef-4d139a02e99b"), Type = TextBlockType.Text, Text = "When it comes to a big heist, every rogue worth their salt knows that magic can throw meticulous plans into chaos, whether in the form of arcane wards or pesky divinations. You dabble in magic just enough to help handle these problems by jury-rigging spells and throwing a bit of your own magic into the mix. You might be a solitary thief, performing burglaries that can't be explained by skill alone, or a specialist called in by other rogues to deal with magical security measures. You might even be on the up-and-up, hired to test magical defenses or even build them yourself." };
            yield return new TextBlock { Id = Guid.Parse("bdabeb45-40f7-4989-8089-b32cb24f74dd"), Type = TextBlockType.Text, Text = "Choose a multiclass archetype that has a basic, expert, and master spellcasting feat. You gain that archetype's dedication feat as a bonus feat even though you don't meet its level prerequisite, though you must meet its other prerequisites. For you, the Magical Trickster rogue feat has a prerequisite of 2nd level instead of 4th level. You can choose the spellcasting ability score for the multiclass archetype you chose as your key ability score." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("8bd7124a-9574-4626-93f5-84cca814ad53"), or => 
            {
                or.AddAnd(Guid.Parse("3e48e4f9-f70b-4a7c-a8e9-99cbb0829fdf"), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse("571b383b-6bec-41f3-b2b9-612624618d51"), Feats.Instances.BardDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse("27a163a1-8d65-4574-803b-f248cde40617"), Feats.Instances.BardDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse("e1da4b1f-1cc5-4e36-a968-6263197fc59b"), Stats.Instances.Charisma.ID);
                });

                or.AddAnd(Guid.Parse("44f2259d-e706-4872-8473-a9d575481824"), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse("f3955d79-b9ea-4e8a-a4c6-53a9d789ffa7"), Feats.Instances.ClericDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse("c6ac20db-4227-4975-9aab-f6098ab3aa3a"), Feats.Instances.ClericDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse("55aabbf7-d5e8-432b-b027-faad4032a1bc"), Stats.Instances.Wisdom.ID);
                });

                or.AddAnd(Guid.Parse("98f83b8f-f62e-4139-ad91-0980716f364e"), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse("25d56be3-a451-4fc6-9d34-09204fa25292"), Feats.Instances.DruidDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse("cbdedf13-add0-419f-be0e-1ebf9bca6137"), Feats.Instances.DruidDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse("34887be8-c0ac-441f-9cea-22fa7cfb502a"), Stats.Instances.Wisdom.ID);
                });

                or.AddAnd(Guid.Parse("10d347b3-d2f9-46a1-87bf-10e976b91d4d"), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse("f0978b71-bbaa-47f8-b177-1fd36f43f69c"), Feats.Instances.MagusDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse("fd525693-c397-4019-bdea-ffe62500f16f"), Feats.Instances.MagusDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse("32e8b13f-e727-4774-a00d-5f5af71edd48"), Stats.Instances.Intelligence.ID);
                });

                or.AddAnd(Guid.Parse("321ba459-987a-4599-ad70-b24946bbedf7"), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse("e2f3d78f-319a-459e-bc11-06ec52209511"), Feats.Instances.OracleDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse("2f46dab3-c530-446c-b2e1-3f4732c8d3ad"), Feats.Instances.OracleDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse("38cc7e80-7b52-4f42-a750-45fb92d7e29e"), Stats.Instances.Charisma.ID);
                });

                or.AddAnd(Guid.Parse("18444a2f-792e-40a5-98f2-74422d90ea2f"), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse("826b0a51-09f3-4d09-b9f9-7b7c77da8ade"), Feats.Instances.SorcererDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse("56804000-ed40-4bf1-a9ed-9816e3a4f21a"), Feats.Instances.SorcererDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse("6ec37f31-9eed-43e7-8148-2cf968d1357a"), Stats.Instances.Charisma.ID);
                });

                or.AddAnd(Guid.Parse("5b1f4f70-ed7a-41d4-88e0-0cab15781b08"), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse("1df026e2-3b68-4b04-bb49-cff686a288e5"), Feats.Instances.WitchDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse("48c2cd89-aa11-4e75-929c-b961338d914a"), Feats.Instances.WitchDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse("dc39b198-df3a-4808-b5cf-16fb0351318f"), Stats.Instances.Intelligence.ID);
                });

                or.AddAnd(Guid.Parse("ee36b3b7-a1ce-45d4-bb81-0f9aace0474d"), and =>
                {
                    and.ModifyFeatLevelPrerequisite(Guid.Parse("b38fb3b6-9c17-433c-8514-f45a21c24ea8"), Feats.Instances.WizardDedication.ID, ModifierType.Multiply, modifier: 0);
                    and.GainSpecificFeat(Guid.Parse("292418de-acb1-4186-be68-97db50c50d1a"), Feats.Instances.WizardDedication.ID);
                    and.GainSpecificKeyAbilityOption(Guid.Parse("482f9bfb-faa5-497e-8309-852d2e564984"), Stats.Instances.Intelligence.ID);
                });
            });
         
            builder.ModifyFeatLevelPrerequisite(Guid.Parse("5f373b7f-bafc-4551-bb29-3a81cb387648"), Feats.Instances.MagicalTrickster.ID, ModifierType.Subtract, modifier: 2);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("535b6397-66e1-4d38-8cd9-6883fc48cb36"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 134
            };
        }
    }
}
