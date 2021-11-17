using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlindFight : Template
    {
        public static readonly Guid ID = Guid.Parse("3e6ce3f7-fbcc-4b94-923f-19bdcd796062");

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
            yield return new TextBlock { Id = Guid.Parse("62f9c0e0-5e35-4001-88c9-0822721004ee"), Type = TextBlockType.Text, Text = "Your battle instincts make you more aware of concealed and invisible opponents. You don’t need to succeed at a flat check to target concealed creatures. You’re not flat-footed to creatures that are hidden from you (unless you’re flat-footed to them for reasons other than the hidden condition), and you need only a successful DC 5 flat check to target a hidden creature." };
            yield return new TextBlock { Id = Guid.Parse("442c3470-571f-4db7-a00e-55e9856f5791"), Type = TextBlockType.Text, Text = "While you’re adjacent to an undetected creature of your level or lower, it is instead only hidden from you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9e957e00-f1ab-4fcf-a0b0-f14397bf8a23"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4a5ab52-23ad-4e13-80ed-f740a8285923"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}