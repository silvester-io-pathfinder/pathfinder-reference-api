using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RunescarredDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ccee0d21-8da8-4224-8f33-3424d429809e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Runescarred Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the runescarred archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c628b013-5d74-48bb-b67f-241ce57676dd"), Type = TextBlockType.Text, Text = "~ Access: You are from the Saga Lands." };
            yield return new TextBlock { Id = Guid.Parse("248e9fca-2160-4644-98a6-37a27ff9f0f9"), Type = TextBlockType.Text, Text = "Whether through blood (if you’re Varisian, Shoanti, or New Thassilonian) or by exposure to rune magic, you have become runescarred, with visible, glowing runes on your body in the form of tattoos or scars. You might have possessed these marks before gaining the archetype, but you only truly became runescarred when you chose to study and tap into the runes’ power. You become an expert in Arcana and you also become trained in Thassilon Lore, or an expert in Thassilon Lore if you were already trained in it." };
            yield return new TextBlock { Id = Guid.Parse("99c84fdd-b75a-498a-a70a-c3aa932d49ce"), Type = TextBlockType.Text, Text = "Choose one cantrip from the arcane list. One of the runes on your body corresponds to the chosen cantrip, and you can cast the chosen cantrip as an innate arcane spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5212f593-b418-4f33-a0b4-b6127bbabcbb"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33e6f148-8743-4479-a680-dc2b3db0fc0b"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
