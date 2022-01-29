using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonstrosityShape : Template
    {
        public static readonly Guid ID = Guid.Parse("06db85c8-9d10-4b2f-b191-f3b7edc4b143");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monstrosity Shape",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("465201a0-62e5-421a-afc6-f12f12df41e6"), Type = TextBlockType.Text, Text = $"You can transform into a powerful magical creature. Add the purple worm and sea serpent forms listed in {ToMarkdownLink<Models.Entities.Spell>("monstrosity form", Spells.Instances.MonstrosityForm.ID)} to your {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)} list. If you have {ToMarkdownLink<Models.Entities.Feat>("Soaring Shape", Feats.Instances.SoaringShape.ID)}, add the phoenix form listed in {ToMarkdownLink<Models.Entities.Spell>("aerial form", Spells.Instances.AerialForm.ID)} to your {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)} list." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d683166f-f164-47ad-b718-67af69121d09"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8efdcdc6-ae98-4036-9a05-10d952b2278a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
