using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EidolonStatistics : Template
    {
        public static readonly Guid ID = Guid.Parse("23ce137a-003a-4701-aad2-2d4c143e8212");

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
            yield return new TextBlock { Id = Guid.Parse("86cf5796-9a83-4f88-898c-f8475f6b2760"), Type = TextBlockType.Text, Text = "Str|Dex|Con|Int|Wis|Cha" };
            yield return new TextBlock { Id = Guid.Parse("b6fcdbd1-5529-408d-9ce1-5b55df828fe7"), Type = TextBlockType.Text, Text = ":-:|:-:|:-:|:-:|:-:|:-:" };
            yield return new TextBlock { Id = Guid.Parse("2409bc3b-f757-4074-af03-1ed171ba92e7"), Type = TextBlockType.Text, Text = "{EIDOLON_SCORE_STR.GET_TOTAL}|{EIDOLON_SCORE_DEX.GET_TOTAL}|{EIDOLON_SCORE_CON.GET_TOTAL}|{EIDOLON_SCORE_INT.GET_TOTAL}|{EIDOLON_SCORE_WIS.GET_TOTAL}|{EIDOLON_SCORE_CHA.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("a241091c-17c9-4ef7-9648-73de80ca46fc"), Type = TextBlockType.Text, Text = "Fortitude|Will|Reflex" };
            yield return new TextBlock { Id = Guid.Parse("7deac0b2-6531-4d00-89a8-aa8118f72811"), Type = TextBlockType.Text, Text = ":-:|:-:|:-:" };
            yield return new TextBlock { Id = Guid.Parse("aa6948ff-14fc-4548-a13f-69af436b2822"), Type = TextBlockType.Text, Text = "+{EIDOLON_SAVE_FORT.GET_TOTAL}|+{EIDOLON_SAVE_WILL.GET_TOTAL}|+{EIDOLON_SAVE_REFLEX.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("8fcb68a3-b95c-4895-8ac3-e3903ec775d3"), Type = TextBlockType.Text, Text = "Name|Value" };
            yield return new TextBlock { Id = Guid.Parse("8eb45b2d-0a72-4e71-b3d5-56690a0c08d6"), Type = TextBlockType.Text, Text = ":--|:--" };
            yield return new TextBlock { Id = Guid.Parse("f92da95a-edc2-4e40-a646-204116631ef6"), Type = TextBlockType.Text, Text = "Type|{EIDOLON_TYPE}" };
            yield return new TextBlock { Id = Guid.Parse("ae7470a7-ed36-4a65-81b7-b4cbe9453047"), Type = TextBlockType.Text, Text = "Traits|{EIDOLON_TRAITS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("dfee1077-c36e-42e2-abb5-483dd66712b6"), Type = TextBlockType.Text, Text = "Unarmed Attacks|{EIDOLON_UNARMED_ATTACKS}" };
            yield return new TextBlock { Id = Guid.Parse("bf9e6914-0bb0-4dd9-b495-2058cfcdc9a9"), Type = TextBlockType.Text, Text = "Unarmored Defense|{EIDOLON_UNARMORED_DEFENSE}" };
            yield return new TextBlock { Id = Guid.Parse("edde24d3-7b65-4b42-9552-7e7004e1ac52"), Type = TextBlockType.Text, Text = "AC Bonus|+{EIDOLON_AC}" };
            yield return new TextBlock { Id = Guid.Parse("bef77419-9c11-4c64-bb94-0912d7224749"), Type = TextBlockType.Text, Text = "AC Dex Cap|+{EIDOLON_DEX_CAP}" };
            yield return new TextBlock { Id = Guid.Parse("ae90a2f4-6b04-4aa6-9a72-5a5217c22bbe"), Type = TextBlockType.Text, Text = "Size|{EIDOLON_SIZE.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("ece6a900-9b53-455e-8835-200f811ab34b"), Type = TextBlockType.Text, Text = "Skills|{EIDOLON_SKILLS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("4243de5d-7e1a-47bf-89b9-90b3e636631d"), Type = TextBlockType.Text, Text = "Perception|+{EIDOLON_PERCEPTION.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("14a19dea-f56b-4eba-9082-29958b0622ba"), Type = TextBlockType.Text, Text = "Senses|{EIDOLON_SENSES.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("3bf2f04e-dce9-46e2-91f7-4f201044a3aa"), Type = TextBlockType.Text, Text = "Languages|{EIDOLON_LANGUAGES.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("b1a758ab-2dc9-4201-be8f-69126f2f388b"), Type = TextBlockType.Text, Text = "Speeds|{EIDOLON_SPEEDS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("279f9bf0-5968-4cf7-a716-ad8de2e7db5d"), Type = TextBlockType.Text, Text = "Resistances|{EIDOLON_RESISTANCES.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("7ed02c1a-e63c-40c8-ae28-b30081964010"), Type = TextBlockType.Text, Text = "Spells|{EIDOLON_SPELLS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("9a787304-cae9-4fba-b274-efb0fbafd609"), Type = TextBlockType.Text, Text = "Extra Feats|{EIDOLON_EXTRA_FEATS.GET_FULL_STRING}" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0db739d7-8737-4d5f-b878-b25d19bdf5b1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
