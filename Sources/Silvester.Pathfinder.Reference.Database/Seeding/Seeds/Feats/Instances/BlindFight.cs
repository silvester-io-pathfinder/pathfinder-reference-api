using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlindFight : Template
    {
        public static readonly Guid ID = Guid.Parse("d36fb449-f73d-487f-922c-c30414d2da81");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blind-Fight",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10135ec2-22e1-4ab9-b694-b92f9bb7acda"), Type = TextBlockType.Text, Text = "Your battle instincts make you more aware of concealed and invisible opponents. You don’t need to succeed at a flat check to target concealed creatures. You’re not flat-footed to creatures that are hidden from you (unless you’re flat-footed to them for reasons other than the hidden condition), and you need only a successful DC 5 flat check to target a hidden creature." };
            yield return new TextBlock { Id = Guid.Parse("7ce92309-5558-4544-b880-fa3cec0cebca"), Type = TextBlockType.Text, Text = "While you’re adjacent to an undetected creature of your level or lower, it is instead only hidden from you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("87a4826f-00e9-4b49-a8cb-538fdacc7735"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74180f18-76ec-48de-8a99-36f97913e760"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
