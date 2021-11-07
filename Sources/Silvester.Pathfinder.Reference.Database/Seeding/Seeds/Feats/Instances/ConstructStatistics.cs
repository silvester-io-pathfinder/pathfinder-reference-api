using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConstructStatistics : Template
    {
        public static readonly Guid ID = Guid.Parse("3b94f88b-716c-47bd-a8b2-9e8ad9c8fccf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Construct Statistics",
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
            yield return new TextBlock { Id = Guid.Parse("cea7d9f3-d2b2-4e29-89d1-9cf60c77d1b1"), Type = TextBlockType.Text, Text = "__(feat: Construct Companion Rules)__" };
            yield return new TextBlock { Id = Guid.Parse("77757335-566c-4b01-8206-a51dfed60544"), Type = TextBlockType.Text, Text = "Str|Dex|Con|Int|Wis|Cha" };
            yield return new TextBlock { Id = Guid.Parse("0a624e8b-c5c8-4031-aceb-18a81f138494"), Type = TextBlockType.Text, Text = ":-:|:-:|:-:|:-:|:-:|:-:" };
            yield return new TextBlock { Id = Guid.Parse("bcdfc9fc-283d-40f4-88eb-e4a71ffb8402"), Type = TextBlockType.Text, Text = "+{INNOVATION_SCORE_STR.GET_TOTAL_MOD}|+{INNOVATION_SCORE_DEX.GET_TOTAL_MOD}|+{INNOVATION_SCORE_CON.GET_TOTAL_MOD}|{INNOVATION_SCORE_INT.GET_TOTAL_MOD}|+{INNOVATION_SCORE_WIS.GET_TOTAL_MOD}|+{INNOVATION_SCORE_CHA.GET_TOTAL_MOD}" };
            yield return new TextBlock { Id = Guid.Parse("5182f398-3d5e-493c-811e-f01a2c2f0673"), Type = TextBlockType.Text, Text = "Fortitude|Will|Reflex" };
            yield return new TextBlock { Id = Guid.Parse("6058a08f-3ef9-4adb-9830-de2bf614bfca"), Type = TextBlockType.Text, Text = ":-:|:-:|:-:" };
            yield return new TextBlock { Id = Guid.Parse("dc77778f-cfb6-45a5-8fa9-93d3760c16c6"), Type = TextBlockType.Text, Text = "+{INNOVATION_SAVE_FORT.GET_TOTAL}|+{INNOVATION_SAVE_WILL.GET_TOTAL}|+{INNOVATION_SAVE_REFLEX.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("130b0373-0a65-49c8-9fe1-cb1a16a76dbd"), Type = TextBlockType.Text, Text = "Name|Value" };
            yield return new TextBlock { Id = Guid.Parse("311d1501-3360-45ba-8386-2977bbd151ed"), Type = TextBlockType.Text, Text = ":--|:--" };
            yield return new TextBlock { Id = Guid.Parse("9654292a-6595-4f0d-9605-5bc68cdbb504"), Type = TextBlockType.Text, Text = "Traits|{INNOVATION_TRAITS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("3272d3b5-fcfe-4555-9cc2-313697dcafa5"), Type = TextBlockType.Text, Text = "Unarmed Attacks|{INNOVATION_UNARMED_ATTACKS}" };
            yield return new TextBlock { Id = Guid.Parse("137c26c5-44f8-4ae8-a7bd-90cfb0600a09"), Type = TextBlockType.Text, Text = "Unarmored Defense|{INNOVATION_UNARMORED_DEFENSE}" };
            yield return new TextBlock { Id = Guid.Parse("fef5fdc0-0348-4b09-b3b2-25e46d9c6fad"), Type = TextBlockType.Text, Text = "Hit Points|{INNOVATION_HP.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("75afe03b-40f0-42fa-88f5-3bae86d86ee2"), Type = TextBlockType.Text, Text = "Resistances|{INNOVATION_RESIST.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("9cdbe208-803a-4f3a-8e74-731ba186aeb9"), Type = TextBlockType.Text, Text = "Speeds|{INNOVATION_SPEEDS.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("853029fd-1502-45ed-8e1a-15a9292b84e9"), Type = TextBlockType.Text, Text = "Size|{INNOVATION_SIZE.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("f2dc2a72-5341-458c-b716-78c79a831212"), Type = TextBlockType.Text, Text = "Perception|+{INNOVATION_PERCEPTION.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("0555dbfd-27d7-4ef9-acf9-46dcade56993"), Type = TextBlockType.Text, Text = "Senses|{INNOVATION_SENSES.GET_FULL_STRING}" };
            yield return new TextBlock { Id = Guid.Parse("23310133-38eb-47a2-95b5-6b79ff8c8c48"), Type = TextBlockType.Text, Text = "Athletics|+{INNOVATION_ATHLETICS.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("8686a935-8545-4697-b461-d0640cdc7c64"), Type = TextBlockType.Text, Text = "Acrobatics|+{INNOVATION_ACROBATICS.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("707d3881-2183-4abe-85db-94ea16ad58ec"), Type = TextBlockType.Text, Text = "Intimidation|+{INNOVATION_INTIMIDATION.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("6c2c3982-72cb-499c-a7b0-5b67579df8b3"), Type = TextBlockType.Text, Text = "Stealth|+{INNOVATION_STEALTH.GET_TOTAL}" };
            yield return new TextBlock { Id = Guid.Parse("35e2a0ab-31b9-45c1-92a2-146e32d3f28d"), Type = TextBlockType.Text, Text = "Survival|+{INNOVATION_SURVIVAL.GET_TOTAL}" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c6ddafa-e081-4d13-a993-decce84d5354"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
