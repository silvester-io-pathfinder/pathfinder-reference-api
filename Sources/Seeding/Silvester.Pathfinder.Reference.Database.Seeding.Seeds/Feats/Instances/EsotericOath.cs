using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EsotericOath : Template
    {
        public static readonly Guid ID = Guid.Parse("3e49277a-b66c-4a87-9f20-216f0495aba7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Esoteric Oath",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1d821e1-24e7-4743-b7c3-db3889de2c09"), Type = TextBlockType.Text, Text = $"You've sworn an oath to slay the alien abominations that lurk in the remote corners of Golarion. Add the following tenet to your champion's code, after the other tenets. “You must slay evil aberrations you encounter as long as you have a reasonable chance of success.”" };
            yield return new TextBlock { Id = Guid.Parse("be130e81-a079-4114-9ee6-dcd3ebe8ff61"), Type = TextBlockType.Text, Text = $"Your {ToMarkdownLink<Models.Entities.Feat>("Retributive Strike", Feats.Instances.RetributiveStrike.ID)} gains a +4 circumstance bonus to damage against an evil aberration, or +6 if you have master proficiency with the weapon you used. The resistance you gain from {ToMarkdownLink<Models.Entities.Feat>("Glimpse of Redemption", Feats.Instances.GlimpseOfRedemption.ID)} against damage from an evil aberration is 7 + your level. If you use {ToMarkdownLink<Models.Entities.Feat>("Liberating Step", Feats.Instances.LiberatingStep.ID)} triggered by an evil aberration, your ally gains a +4 circumstance bonus to checks granted by your {ToMarkdownLink<Models.Entities.Feat>("Liberating Step", Feats.Instances.LiberatingStep.ID)}, and the ally can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} twice afterward." };
            yield return new TextBlock { Id = Guid.Parse("82bd0b14-80d0-4935-8172-e2367c3266d5"), Type = TextBlockType.Text, Text = $"You don't consider evil aberrations to be legitimate authorities, even in nations they rule." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("a0d94761-da25-4f96-bc38-3ebd0012faa8"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("211de3bb-eac2-458c-945b-871d9c207845"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
