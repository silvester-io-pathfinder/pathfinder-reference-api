using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefensiveInstincts : Template
    {
        public static readonly Guid ID = Guid.Parse("fbaf4a55-0794-49bd-b9d1-6d1b58e94f31");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defensive Instincts",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2abeb940-2ec5-4539-9e4e-fa0a88f3356c"), Type = TextBlockType.Text, Text = "Your body tenses up when surrounded, putting you on edge just enough to anticipate an attack. You gain a +1 circumstance bonus to AC until the beginning of your next turn and (action: Step)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("9b633894-cd04-44ee-961b-14df850db577"), "You are adjecent to at least two enemies.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a53f46eb-8e1f-4712-a409-ac0b626edf24"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
