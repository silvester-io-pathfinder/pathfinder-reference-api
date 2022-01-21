using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BouncyGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("14e76bf4-a354-42cd-b924-614110f7e51a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bouncy Goblin",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bffb09c1-3b3e-4227-a769-df553bf4ac71"), Type = TextBlockType.Text, Text = $"You have a particular elasticity that makes it easy for you to bounce and squish. You gain the trained proficiency rank in Acrobatics (or another skill of your choice, if you were already trained in Acrobatics). You also gain a +2 circumstance bonus to Acrobatics checks to {ToMarkdownLink<Models.Entities.SkillAction>("Tumble Through", SkillActions.Instances.TumbleThrough.ID)} a foe's space." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("537b3519-6eeb-46a7-bdc6-aa8ba0bfa15b"), Heritages.Instances.UnbreakableGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55ae7db4-0c7e-48a9-90b0-8a53acc80d6b"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
