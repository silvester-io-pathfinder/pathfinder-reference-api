using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EidolonStatistics : Template
    {
        public static readonly Guid ID = Guid.Parse("1aa44de6-1498-4dc7-9584-8380dd28e5a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eidolon Statistics",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("77255e36-3d2a-40da-acfa-a21d814f19fd"), Type = TextBlockType.Text, Text = "Str|Dex|Con|Int|Wis|Cha" };
            yield return new TextBlock { Id = Guid.Parse("928089f7-f3f0-4418-ba3c-d5c9bd7fe687"), Type = TextBlockType.Text, Text = ":-:|:-:|:-:|:-:|:-:|:-:" };
            yield return new TextBlock { Id = Guid.Parse("4684a511-c401-470e-aa23-04465b390d26"), Type = TextBlockType.Text, Text = "{EIDOLON_SCORE_STR.GET_TOTAL}|{EIDOLON_SCORE_DEX.GET_TOTAL}|{EIDOLON_SCORE_CON.GET_TOTAL}|{EIDOLON_SCORE_INT.GET_TOTAL}|{EIDOLON_SCORE_WIS.GET_TOTAL}|{EIDOLON_SCORE_CHA.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("dc1f0dc1-ae05-4460-90c2-a641754631ef"), Type = TextBlockType.Text, Text = "Fortitude|Will|Reflex" };
            yield return new TextBlock { Id = Guid.Parse("36e5d748-c60a-4a3e-8f99-9c7191c1d68e"), Type = TextBlockType.Text, Text = ":-:|:-:|:-:" };
            yield return new TextBlock { Id = Guid.Parse("31071b80-bb34-4287-b5de-95879be33aaf"), Type = TextBlockType.Text, Text = "+{EIDOLON_SAVE_FORT.GET_TOTAL}|+{EIDOLON_SAVE_WILL.GET_TOTAL}|+{EIDOLON_SAVE_REFLEX.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("4fa3892a-d292-46cf-b0be-e7af262b5b91"), Type = TextBlockType.Text, Text = "Name|Value" };
            yield return new TextBlock { Id = Guid.Parse("0470903f-5685-43a7-96fa-de149a47f521"), Type = TextBlockType.Text, Text = ":--|:--" };
            yield return new TextBlock { Id = Guid.Parse("b6e26e31-506c-4aaa-a513-3f65eb1682f3"), Type = TextBlockType.Text, Text = "Type|{EIDOLON_TYPE}" };
            yield return new TextBlock { Id = Guid.Parse("ef55d801-484d-43ee-81cc-659c1654971f"), Type = TextBlockType.Text, Text = "Traits|{EIDOLON_TRAITS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("b9b130a4-2497-496d-a06b-603d5a57e748"), Type = TextBlockType.Text, Text = "Unarmed Attacks|{EIDOLON_UNARMED_ATTACKS}" };
            yield return new TextBlock { Id = Guid.Parse("36378d2b-48b8-4a63-8483-59007b17a6af"), Type = TextBlockType.Text, Text = "Unarmored Defense|{EIDOLON_UNARMORED_DEFENSE}" };
            yield return new TextBlock { Id = Guid.Parse("90cec88b-c863-4295-8071-8dd11f336a52"), Type = TextBlockType.Text, Text = "AC Bonus|+{EIDOLON_AC}" };
            yield return new TextBlock { Id = Guid.Parse("a8272bf7-abc7-4238-b1bb-79d1861361c0"), Type = TextBlockType.Text, Text = "AC Dex Cap|+{EIDOLON_DEX_CAP}" };
            yield return new TextBlock { Id = Guid.Parse("e415f131-c633-486c-b17f-a4946101cf4e"), Type = TextBlockType.Text, Text = "Size|{EIDOLON_SIZE.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("080a0670-7059-4e30-a9fa-992666b69d0d"), Type = TextBlockType.Text, Text = "Skills|{EIDOLON_SKILLS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("d2daad89-2c73-4c33-b23f-5c0d83761b68"), Type = TextBlockType.Text, Text = "Perception|+{EIDOLON_PERCEPTION.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("e9ed5d7f-9f2d-46cd-b7d2-9a9f58be77f2"), Type = TextBlockType.Text, Text = "Senses|{EIDOLON_SENSES.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("e4f3f96a-f216-42c4-83b2-f21daaf1b99d"), Type = TextBlockType.Text, Text = "Languages|{EIDOLON_LANGUAGES.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("6f20f806-eee0-4cc3-890c-00335448b09e"), Type = TextBlockType.Text, Text = "Speeds|{EIDOLON_SPEEDS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("0188bf6f-0d81-47bc-8380-eb8eb7d72e2b"), Type = TextBlockType.Text, Text = "Resistances|{EIDOLON_RESISTANCES.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("ffea8567-29cc-41d8-85a9-125a5fd3b421"), Type = TextBlockType.Text, Text = "Spells|{EIDOLON_SPELLS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("eed21ce3-e958-4cd3-a006-09088ed5ad16"), Type = TextBlockType.Text, Text = "Extra Feats|{EIDOLON_EXTRA_FEATS.GET_FULL_STRING}" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d2fb1f2-1e68-480d-9b4c-b38c2ff490bf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
