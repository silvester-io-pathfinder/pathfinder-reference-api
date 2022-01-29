using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecondSting : Template
    {
        public static readonly Guid ID = Guid.Parse("7a69b742-58a4-40b9-a957-add5dccecf9e");

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
            yield return new TextBlock { Id = Guid.Parse("4292a13a-e104-435d-8d48-565e5bc27e8e"), Type = TextBlockType.Text, Text = $"You read your prey's movements and transform them into openings, so failures with one weapon set up glancing blows with the other. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with one of the required weapons against your hunted prey. The {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} gains the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("16c00be2-b883-45bd-a78c-1eac6aefaa42"),
                
                
                Failure = "You deal the damage the other required weapon would have dealt on a hit, excluding all damage dice. __(This removes dice from weapon runes, spells, and special abilities, not just weapon damage dice.)__",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fd18763-7872-4a87-afe5-35e63387554d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
