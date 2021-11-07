using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecondSting : Template
    {
        public static readonly Guid ID = Guid.Parse("f25b8caf-fe32-4e93-b187-8ed233c025b6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Second Sting",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee01ad9e-ec93-4c67-851e-9d8e4d473fa6"), Type = TextBlockType.Text, Text = "You read your prey’s movements and transform them into openings, so failures with one weapon set up glancing blows with the other. Make a melee (action: Strike) with one of the required weapons against your hunted prey. The (action: Strike) gains the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("007c3e91-2ef6-4cd4-bdc0-363dd1fcaa4b"),
                
                
                Failure = "You deal the damage the other required weapon would have dealt on a hit, excluding all damage dice. __(This removes dice from weapon runes, spells, and special abilities, not just weapon damage dice.)__",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e9e3bd7-369f-46e2-b628-e879cbf38b71"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
